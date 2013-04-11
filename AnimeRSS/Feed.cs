using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AnimeRSS
{
    public class Feed
    {
        private string name;
        private string url;

        private List<FeedItem> feedItems = new List<FeedItem>();

        public Feed(string name, string url)
        {
            this.name = name;
            this.url = url;
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Url
        {
            get { return this.url; }
        }

        public void ReadFeed(string feedUrl)
        {
            var feed = from c in XDocument.Load(@feedUrl).Descendants("item")
                       select new
                       {
                           title = c.Element("title").Value,
                           downloadUrl = c.Element("link").Value,
                           date = c.Element("pubDate").Value,
                           description = c.Element("description").Value
                       };

            foreach (var item in feed) { feedItems.Add(new FeedItem(item.title, item.downloadUrl, item.date, item.description)); }

            SetResolution();

        }

        public void RefreshFeed()
        {
            this.feedItems.Clear();
            ReadFeed(this.url);
            if (WindowForm.removeLowres) { RemoveLowres(); }
        }

        public List<FeedItem> GetItems
        {
            get
            {
                ResizeList();
                return feedItems;
            }
        }

        public void ResizeList()
        {
            if (feedItems.Count > WindowForm.maxItems)
            {
                this.feedItems.RemoveRange(WindowForm.maxItems, feedItems.Count - WindowForm.maxItems);
            }
        }

        public void RemoveLowres()
        {
            List<FeedItem> tempList = new List<FeedItem>();

            foreach (FeedItem fi in this.feedItems)
            {
                if (fi.Title.Contains("360p") == false && fi.Title.Contains("480p") == false)
                {
                    tempList.Add(fi);
                }
            }

            this.feedItems = tempList;
        }

        public void SetResolution()
        {
            string regularExpression = @"\[(.*?)\]";

            foreach (FeedItem f in this.feedItems)
            {
                MatchCollection matches = Regex.Matches(f.Title, @regularExpression);

                foreach (Match m in matches)
                {
                    if (m.Value.Contains("1080p")) { f.Resolution = "1080p"; }
                    if (m.Value.Contains("720p")) { f.Resolution = "720p"; }                  
                    if (m.Value.Contains("480p")) { f.Resolution = "480p"; }
                    if (m.Value.Contains("360p")) { f.Resolution = "360p"; }
                }
            }
        }
    }

    public class FeedItem
    {
        private string title;
        private string url;
        private string day;
        private string description;
        private string originalTitle;
        private string resolution;
        private int episode;

        public FeedItem(string title, string url, string date, string description)
        {
            this.title = title;
            this.url = url;
            this.day = Convert.ToDateTime(date.Remove((date.Length - 6), 6)).ToString("ddd", new CultureInfo("en-US"));
            this.description = description;
            this.originalTitle = title;
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Url
        {
            get { return this.url; }
        }

        public string Day
        {
            get { return this.day; }
        }

        public string Description
        {
            get { return this.description; }
        }

        public string OriginalTitle
        {
            get { return this.originalTitle; }
        }

        public string Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }
    }
}
