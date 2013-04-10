using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeRSS.AutoDownloader
{
    public class RssDownload
    {
        public string title;
        public string resolution;
        public int epFrom;
        public int epTo;
        public int lastDownloadedEp;
        public Feed feed;

        public RssDownload(string title, string resolution, int epFrom, int epTo, string feed, int lastDownloadedEp)
        {
            this.title = title;
            this.resolution = resolution;
            this.epFrom = epFrom;
            this.epTo = epTo;
            this.lastDownloadedEp = lastDownloadedEp;

            foreach (Feed f in AnimeRSS.WindowForm.feeds)
            {
                if (f.Name == feed)
                {
                    this.feed = f;
                    break;
                }
            }

            CheckItems();
        }

        public void CheckItems()
        {
            foreach (FeedItem fi in feed.GetItems)
            {
                if (fi.Title.ToLower().Contains(this.title))
                {
                    if (fi.Resolution == this.resolution || fi.Resolution == null)
                    {
                        string[] tempStringArray = fi.OriginalTitle.Split(new char[] { '-' });
                        int ep = Convert.ToInt32(tempStringArray[1].Remove(3, tempStringArray[1].Length - 3));

                        if (this.epFrom >= ep && this.epTo >= ep)
                        {
                            if ((this.epTo > ep))
                            {
                                if (ep > this.lastDownloadedEp)
                                {
                                    this.lastDownloadedEp = ep;

                                    string url = fi.Url;
                                    WebBrowser wb = new WebBrowser();
                                    wb.Navigate(url);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
