using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using NyaaBrowser;
using AnimeRSS.AutoDownloader;

namespace AnimeRSS
{
    public partial class WindowForm : Form
    {
        public static List<Feed> feeds = new List<Feed>();
        public static ArrayList listViews = new ArrayList();
        public static List<RssDownload> rssDownloads = new List<RssDownload>();

        public static bool formattingEnabled;
        public static bool hashHidingEnabled;
        public static bool prefixItemDate;
        public static int refreshRate;
        public static bool showOnTaskbar;
        public static Color customFontColor = SystemColors.ControlText;
        public static Color customBGColor = SystemColors.Control;
        public static Font customFont = DefaultFont;
        public static int maxItems = 30;
        public static bool removeLowres = false;
        public static bool showToolTip = false;
        public static bool removeOtherMess = true;

        public WindowForm()
        {
            InitializeComponent();
            LoadData();
            RefreshF();
            this.Text = "Anime RSS - " + this.FeedsTabs.TabPages[0].Text;
        }

        private void newFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string feedName = null;
            string feedUrl = null;

            while (feedName == null)
            {
                feedName = Interaction.InputBox("Enter feed name.");
                if (feedName == "") { break; }
            }

            if (feedName != "")
            {

                while (feedUrl == null)
                {
                    feedUrl = Interaction.InputBox("Enter feed url.");
                    if (feedUrl == "") { break; }
                }

                if (feedName != "" && feedUrl != "")
                {
                    NewFeed(feedName, feedUrl);
                }
            }
        }

        private void NewFeed(string feedName, string feedUrl)
        {
            TabPage newTab = new TabPage(feedName);
            ListBox newList = new ListBox();
            FeedsTabs.Controls.Add(newTab);

            feeds.Add(new Feed(feedName, feedUrl));

            feeds[FeedsTabs.TabCount - 1].ReadFeed(feedUrl);

            newList.Dock = DockStyle.Fill;
            newList.BorderStyle = BorderStyle.None;
            newList.MouseMove += newList_MouseMove;
            newList.MouseHover += newList_MouseHover;
            newList.BackColor = customBGColor;

            newTab.Controls.Add(newList);

            AddItems(newList, FeedsTabs.TabCount - 1);

            listViews.Add(newList);
        }

        void newList_MouseHover(object sender, EventArgs e)
        {
            if (showToolTip)
            {
                if (sender is ListBox)
                {
                    ListBox lb = (ListBox)sender;
                    int hoverIndex = lb.IndexFromPoint(new Point(hoveredItem.X, hoveredItem.Y));
                    if (hoverIndex >= 0 && hoverIndex < lb.Items.Count)
                    {
                        Feed currentFeed;
                        FeedItem currentFeedItem;

                        currentFeed = feeds[(int)this.FeedsTabs.SelectedIndex];
                        currentFeedItem = currentFeed.GetItems[hoverIndex];


                        itemTooltip.AutomaticDelay = 0;
                        itemTooltip.ReshowDelay = 0;
                        itemTooltip.InitialDelay = 0;
                        itemTooltip.SetToolTip(lb, currentFeedItem.OriginalTitle + " | " + currentFeedItem.Description);
                    }
                }
            }
        }

        static public Point hoveredItem = new Point(0, 0);
        
        void newList_MouseMove(object sender, MouseEventArgs e)
        {
            if (showToolTip)
            {
                if (sender is ListBox)
                {
                    ListBox lb = (ListBox)sender;
                    Point p = new Point(e.X, e.Y);
                    hoveredItem = p;
                }
            }
        }
        
        private void newList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string url = feeds[this.FeedsTabs.SelectedIndex].GetItems[((ListBox)sender).SelectedIndex].Url;

            WebBrowser wb = new WebBrowser();
            wb.FileDownload += new EventHandler(this.wb_FileDownload);
            wb.Navigate(url);
            if (download) { wb.Dispose(); download = false; }
        }

        private static bool download = false;

        private void wb_FileDownload(object sender, EventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;

            if (wb.DocumentType == "File") { download = true; }
        }

        private void WindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
        }

        private void SaveRssDownloaderData()
        {
            XmlWriter x = XmlWriter.Create("AutoDownloadSaveData.xml");
            x.WriteStartElement("savedata");

            foreach (RssDownload rd in rssDownloads)
            {
                x.WriteStartElement("item");
                x.WriteElementString("title", rd.title);
                x.WriteElementString("resolution", rd.resolution);
                x.WriteElementString("epFrom", rd.epFrom.ToString());
                x.WriteElementString("epTo", rd.epTo.ToString());
                x.WriteElementString("lastDownloadedEp", rd.lastDownloadedEp.ToString());
                x.WriteElementString("feed", rd.feed.Name);
                x.WriteEndElement();
            }

            x.WriteEndElement();
            x.Close();
            x.Dispose();
        }

        private void SaveData()
        {
            XmlWriter x = XmlWriter.Create("SaveData.xml");
            x.WriteStartElement("feeds");

            foreach (Feed i in feeds)
            {
                x.WriteStartElement("feed");
                x.WriteElementString("name", i.Name);
                x.WriteElementString("url", i.Url);
                x.WriteEndElement();
            }

            x.WriteEndElement();
            x.Close();
            x.Dispose();

            XmlWriter s = XmlWriter.Create("Settings.xml");
            s.WriteStartElement("settings");
                s.WriteElementString("formatting", formattingEnabled.ToString());
                s.WriteElementString("hashHiding", hashHidingEnabled.ToString());
                s.WriteElementString("prefixDate", prefixItemDate.ToString());
                s.WriteElementString("refreshRate", Convert.ToString(refreshRate));
                s.WriteElementString("showOnTask", showOnTaskbar.ToString());
                s.WriteStartElement("fontColor");
                    s.WriteElementString("a", customFontColor.A.ToString());
                    s.WriteElementString("r", customFontColor.R.ToString());
                    s.WriteElementString("g", customFontColor.G.ToString());
                    s.WriteElementString("b", customFontColor.B.ToString());
                s.WriteEndElement();
                s.WriteStartElement("bgColor");
                    s.WriteElementString("a", customBGColor.A.ToString());
                    s.WriteElementString("r", customBGColor.R.ToString());
                    s.WriteElementString("g", customBGColor.G.ToString());
                    s.WriteElementString("b", customBGColor.B.ToString());
                s.WriteEndElement();
                s.WriteElementString("font", customFont.FontFamily.Name);
                s.WriteElementString("fontSize", Convert.ToString(customFont.Size));
                s.WriteElementString("maxItems", Convert.ToString(maxItems));
                s.WriteElementString("removeLowres", removeLowres.ToString());
                s.WriteElementString("showToolTip", showToolTip.ToString());
                s.WriteElementString("removeOtherMess", removeOtherMess.ToString());
                s.WriteEndElement();
            s.Close();
            s.Dispose();

            SaveRssDownloaderData();
        }

        private void LoadData()
        {
            if (!File.Exists("SaveData.xml"))
            {
                NewFeed("Commie", "http://www.nyaa.eu/?page=rss&user=76430");
            }
            else
            {
                var SaveData = from x in XDocument.Load("SaveData.xml").Descendants("feed")
                               select new
                               {
                                   name = x.Element("name").Value,
                                   url = x.Element("url").Value
                               };

                foreach (var x in SaveData)
                {
                    NewFeed(x.name, x.url);
                }
            }

            if (!File.Exists("Settings.xml"))
            {
                formattingEnabled = false;
                hashHidingEnabled = false;
                prefixItemDate = false;
                refreshRate = 600000;
            }
            else
            {
                var settings = from x in XDocument.Load("Settings.xml").Descendants("settings")
                               select new
                               {
                                   formatting = x.Element("formatting").Value,
                                   hash = x.Element("hashHiding").Value,
                                   prefix = x.Element("prefixDate").Value,
                                   refreshRate = x.Element("refreshRate").Value,
                                   showOnTask = x.Element("showOnTask").Value,
                                   fontColorA = x.Element("fontColor").Element("a").Value,
                                   fontColorR = x.Element("fontColor").Element("r").Value,
                                   fontColorG = x.Element("fontColor").Element("g").Value,
                                   fontColorB = x.Element("fontColor").Element("b").Value,
                                   bgColorA = x.Element("bgColor").Element("a").Value,
                                   bgColorR = x.Element("bgColor").Element("r").Value,
                                   bgColorG = x.Element("bgColor").Element("g").Value,
                                   bgColorB = x.Element("bgColor").Element("b").Value,
                                   font = x.Element("font").Value,
                                   fontSize = x.Element("fontSize").Value,
                                   maxItems = x.Element("maxItems").Value,
                                   removeLowres = x.Element("removeLowres").Value,
                                   showToolTip = x.Element("showToolTip").Value,
                                   removeMess = x.Element("removeOtherMess").Value
                               };

                foreach (var item in settings)
                {
                    formattingEnabled = Convert.ToBoolean(item.formatting);
                    hashHidingEnabled = Convert.ToBoolean(item.hash);
                    prefixItemDate = Convert.ToBoolean(item.prefix);
                    refreshRate = Convert.ToInt32(item.refreshRate);
                    showOnTaskbar = Convert.ToBoolean(item.showOnTask);
                    customFontColor = Color.FromArgb(
                        Convert.ToInt32(item.fontColorA), 
                        Convert.ToInt32(item.fontColorR), 
                        Convert.ToInt32(item.fontColorG), 
                        Convert.ToInt32(item.fontColorB));
                    customBGColor = Color.FromArgb(
                        Convert.ToInt32(item.bgColorA),
                        Convert.ToInt32(item.bgColorR),
                        Convert.ToInt32(item.bgColorG),
                        Convert.ToInt32(item.bgColorB));
                    customFont = new Font(item.font, (float)Convert.ToDecimal(item.fontSize));
                    maxItems = Convert.ToInt32(item.maxItems);
                    removeLowres = Convert.ToBoolean(item.removeLowres);
                    showToolTip = Convert.ToBoolean(item.showToolTip);
                    removeOtherMess = Convert.ToBoolean(item.removeMess);
                }              
            }

            if (File.Exists("AutoDownloadSaveData.xml"))
            {
                var autoDownloader = from x in XDocument.Load("AutoDownloadSaveData.xml").Descendants("item")
                                     select new
                                     {
                                         title = x.Element("title").Value,
                                         resolution = x.Element("resolution").Value,
                                         epFrom = x.Element("epFrom").Value,
                                         epTo = x.Element("epTo").Value,
                                         lastDownloadedEp = x.Element("lastDownloadedEp").Value,
                                         feed = x.Element("feed").Value
                                     };

                foreach (var item in autoDownloader)
                {
                    rssDownloads.Add(new RssDownload(   item.title, 
                                                        item.resolution, 
                                                        Convert.ToInt32(item.epFrom), 
                                                        Convert.ToInt32(item.epTo), 
                                                        item.feed, 
                                                        Convert.ToInt32(item.lastDownloadedEp)
                                                        ));
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show(this);
        }

            
        

        private void RefreshF()
        {
            foreach (Feed f in feeds) { f.RefreshFeed(); }

            CheckSettings();

            int index = 0;

            foreach (Feed f in feeds)
            {
                AddItems((ListBox)listViews[index], index);
                index++;
            }

            ChangeFontColor();

            foreach (RssDownload rd in rssDownloads) { rd.CheckItems(); }
        }

        private void CheckSettings()
        {
            if (formattingEnabled) { FormatFeedItems(); }
            if (hashHidingEnabled) { RemoveHash(); }
            if (prefixItemDate) { PrefixDate(); }
            if (removeOtherMess) { RemoveOtherMess(); }
            this.ShowInTaskbar = showOnTaskbar;
        }

        private void FormatFeedItems()
        {
            if (!File.Exists("formatting.txt"))
            {
                File.Create("formatting.txt").Close();
                StreamWriter writer = new StreamWriter("formatting.txt");
                writer.WriteLine(";Put your formatting strings here.");
                writer.WriteLine(";Strings entered here will be deleted from the item name.");
                writer.WriteLine(";To replace a string with another place them on the same line, seperated by ','.");
                writer.WriteLine(";Example: string,replacement");
                writer.Close();
            }
            else
            {
                List<string> formattingStrings = new List<string>();
                StreamReader reader = new StreamReader("formatting.txt");

                while (true)
                {
                    string read = reader.ReadLine();
                    if (read == null)
                    {
                        reader.Close();
                        foreach (Feed f in feeds)
                        {
                            foreach (FeedItem i in f.GetItems)
                            {
                                foreach (string s in formattingStrings)
                                {
                                    if (s.Contains(","))
                                    {
                                        string[] strArray = s.Split(new char[] { Convert.ToChar(",") });
                                        i.Title = i.Title.Replace(strArray[0], strArray[1]);
                                    }
                                    else
                                    {
                                        i.Title = i.Title.Replace(s, "");
                                    }
                                }
                            }
                        }
                        return;
                    }
                    if (!read.StartsWith(";")) { formattingStrings.Add(read); }
                }
            }
        }

        private void PrefixDate()
        {
            foreach (Feed feed in feeds)
            {
                foreach (FeedItem item in feed.GetItems)
                {
                    string datePrefix = item.Day + "\t│";
                    item.Title = datePrefix + item.Title;
                }
            }
        }

        private void RemoveHash()
        {
            foreach (Feed feed in feeds)
            {
                foreach (FeedItem item in feed.GetItems)
                {
                    item.Title = Regex.Replace(item.Title, @"\[[^\]]{8}\]", "");
                }
            }
        }

        private void AddItems(ListBox lb, int index)
        {
            lb.SelectedIndexChanged -= new EventHandler(this.newList_SelectedIndexChanged);
            lb.DataSource = (from i in feeds[index].GetItems
                             select i.Title).ToList<string>();
            lb.SelectedIndex = -1;
            lb.SelectedIndexChanged += new EventHandler(this.newList_SelectedIndexChanged);
        }

        private void formattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("formatting.txt"))
            {
                File.Create("formatting.txt").Close();
                StreamWriter writer = new StreamWriter("formatting.txt");
                writer.WriteLine(";Put your formatting strings here.");
                writer.WriteLine(";Strings entered here will be deleted from the item name.");
                writer.WriteLine(";To replace a string with another place them on the same line, seperated by ','.");
                writer.WriteLine(";Example: string,replacement");
                writer.Close();
            }

            Process.Start("formatting.txt");
        }

        private void RefreshFeeds_Tick(object sender, EventArgs e)
        {
            RefreshF();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            Application.Exit();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                if (base.WindowState == FormWindowState.Minimized)
                {
                    base.Show();
                    base.WindowState = FormWindowState.Normal;
                }
                else if (base.WindowState == FormWindowState.Normal)
                {
                    base.WindowState = FormWindowState.Minimized;
                    base.Hide();
                }
            }
        }

        private void deleteFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.FeedsTabs.SelectedIndex;

            feeds.RemoveAt(index);
            ((ListBox)listViews[index]).Dispose();
            FeedsTabs.TabPages.RemoveAt(index);
        }

        private void ChangeFontColor()
        {
            foreach (ListBox i in listViews)
            {
                i.ForeColor = customFontColor;
                i.BackColor = customBGColor;
            }

            foreach (TabPage t in FeedsTabs.TabPages)
            {
                t.ForeColor = customFontColor;
            }

            this.Refresh();
            FeedsTabs.Refresh();

            this.FeedsTabs.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.FeedsTabs.DrawItem += new DrawItemEventHandler(tabParamType_DrawItem);
            this.itemTooltip.ForeColor = customFontColor;
        }

        void tabParamType_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeTabColor(e);
            ChangeFont();
        }

        private void ChangeTabColor(DrawItemEventArgs e)
        {
            Font TabFont;
            Brush BackBrush = new SolidBrush(SystemColors.Control);
            Brush ForeBrush = new SolidBrush(customFontColor);
            if (e.Index == this.FeedsTabs.SelectedIndex)
            {
                TabFont = new Font(e.Font, FontStyle.Regular);
            }
            else
            {
                TabFont = e.Font;
            }
            string TabName = this.FeedsTabs.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(BackBrush, e.Bounds);
            Rectangle r = e.Bounds;
            r = new Rectangle(r.X , r.Y + 3, e.Bounds.Width + 5, r.Height - 3);
            e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);


            sf.Dispose();
            if (e.Index == this.FeedsTabs.SelectedIndex)
            {
                TabFont.Dispose();
                BackBrush.Dispose();
            }
            else
            {
                BackBrush.Dispose();
                ForeBrush.Dispose();
            }
        }

        private void ChangeFont()
        {
            this.Font = customFont;

            foreach (ListBox l in listViews)
            {
                l.Font = customFont;
            }

            foreach (TabPage t in FeedsTabs.TabPages)
            {
                t.Font = customFont;
            }
        }

        private void FeedsTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTab = (TabPage)((TabControl)sender).SelectedTab;
            WindowForm.ActiveForm.Text = "Anime RSS - " + currentTab.Text;
        }

        private void refreshStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshF();
            this.RefreshFeeds.Interval = refreshRate;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void RemoveOtherMess()
        {
            foreach (Feed f in feeds)
            {
                foreach (FeedItem fi in f.GetItems)
                {
                    string newTitle = fi.Title;

                    newTitle = Regex.Replace(newTitle, @"\[([^]]+)\]", "");
                    if (newTitle.Contains("[BD]"))
                    {
                        newTitle = newTitle.Replace("[BD]", "");
                    }
                    if (fi.Resolution != null) { newTitle += fi.Resolution; }

                    fi.Title = newTitle;
                }
            }
        }

        private void searchNyaaToolStrip_Click(object sender, EventArgs e)
        {
            Form nyaa = new NyaaBrowserForm();
            nyaa.Show(this);
        }

        private void autoDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form downloader = new AutoDownloader.AutoDownloader();
            downloader.Show();
        }
    }
}
