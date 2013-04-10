using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeRSS.AutoDownloader
{
    public partial class AutoDownloader : Form
    {
        public AutoDownloader()
        {
            InitializeComponent();
            
            foreach (Feed f in AnimeRSS.WindowForm.feeds)
            {
                this.feedCombobox.Items.Add(f.Name);
            }

            Clear();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            AnimeRSS.WindowForm.rssDownloads.Add(new RssDownload(
                                                                    this.titleTextbox.Text, 
                                                                    this.resolutionComboBox.Text, 
                                                                    Convert.ToInt32(this.epFromNum.Value), 
                                                                    Convert.ToInt32(this.epToNum.Value), 
                                                                    this.feedCombobox.Text,
                                                                    0
                                                                    ));
            
            Clear();
        }

        private void clearButton_Click(object sender, EventArgs e) { Clear(); }

        private void Clear()
        {
            this.titleTextbox.Clear();
            this.resolutionComboBox.SelectedIndex = 0;
            this.epFromNum.Value = 1;
            this.epToNum.Value = 1;
            this.feedCombobox.SelectedIndex = 0;
            this.autoDownloadList.Items.Clear();

            foreach (RssDownload rd in AnimeRSS.WindowForm.rssDownloads)
            {
                this.autoDownloadList.Items.Add(rd.title);
            }
        }

        private static int index;

        private void autoDownloadList_MouseDown(object sender , MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListBox lb = sender as ListBox;
                index = lb.IndexFromPoint(e.Location);
            }
        }

        public void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimeRSS.WindowForm.rssDownloads.RemoveAt(index);
            Clear();
        }
    }
}
