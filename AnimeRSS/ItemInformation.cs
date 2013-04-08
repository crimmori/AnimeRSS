using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Diagnostics;

namespace NyaaBrowser
{
    public partial class ItemInformation : Form
    {
        private static FeedItem selectedItem;

        public ItemInformation(FeedItem item)
        {
            InitializeComponent();

            selectedItem = item;

            this.Text = item.title;
            this.titleLabel.Text += item.title;
            this.categoryLabel.Text += item.category;
            this.seedsLabel.Text += Convert.ToString(item.seeds);
            this.peersLabel.Text += Convert.ToString(item.peers);
            this.downloadsLabel.Text += Convert.ToString(item.downloads);
            this.sizeLabel.Text += item.size;
            this.dateLabel.Text += item.pubDate.ToShortDateString();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.Navigate(selectedItem.link);
            wb.Dispose();
        }

        private void openInBrowserButton_Click(object sender, EventArgs e)
        {
            Process.Start(selectedItem.guidLink);

        }
    }
}
