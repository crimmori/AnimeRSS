using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace NyaaBrowser
{
    public class Functions
    {
        private static string searchUrlRSS = "http://www.nyaa.eu/?page=rss&term=";

        private static List<FeedItem> QueryItems;

        public static List<FeedItem> Search(string query)
        {
            QueryItems = new List<FeedItem>();

            GetRSS(searchUrlRSS + query);

            return QueryItems;
        }

        private static void GetRSS(string url)
        {
            var rssFeed = from c in XDocument.Load(@url).Descendants("item")
                          select new
                          {
                              title = c.Element("title").Value,
                              category = c.Element("category").Value,
                              link = c.Element("link").Value,
                              guidLink = c.Element("guid").Value,
                              description = c.Element("description").Value,
                              pubDate = c.Element("pubDate").Value
                          };

            foreach (var item in rssFeed) { QueryItems.Add(new FeedItem(item.title, item.category, item.link, item.guidLink, item.description, item.pubDate)); }

            if (QueryItems.Count > 50)
            {
                QueryItems.RemoveRange(QueryItems.Count - 50, 50);
            }
        }
    }

    public class FeedItem
    {
        public string title;
        public string category;
        public string link;
        public string guidLink;
        public int seeds;
        public int peers;
        public int downloads;
        public string size;
        public string subType;
        public DateTime pubDate;

        public FeedItem(string title, string category, string link, string guidLink, string description, string pubDate)
        {
            this.title = title;
            this.category = category;
            this.link = link;
            this.guidLink = guidLink;

            string seedsString = description.Split(new char[] { ',' })[0];
            this.seeds = Convert.ToInt32(seedsString.Remove((seedsString.Length - 10), 10));

            string peersString = description.Split(new char[] { ',' })[1];
            this.peers = Convert.ToInt32(peersString.Remove((peersString.Length - 11), 11));

            string downloadsString = description.Split(new char[] { ',' })[2].Split(new char[] { '-' })[0];
            this.downloads = Convert.ToInt32(downloadsString.Remove((downloadsString.Length - 13), 13));

            this.size = description.Split(new char[] { ',' })[2].Split(new char[] { '-' })[1].Remove(0, 1);

            if (description.Split(new char[] { ',' })[2].Split(new char[] { '-' }).Length > 2)
            {
                this.subType = description.Split(new char[] { ',' })[2].Split(new char[] { '-' })[2].Remove(0, 1);
            }

            this.pubDate = Convert.ToDateTime(pubDate);
        }
    }
}
