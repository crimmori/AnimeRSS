using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml.Linq;
using System.IO;

namespace NyaaBrowser
{
    public partial class NyaaBrowserForm : Form
    {
        private static List<FeedItem> QueryItems = null;

        public NyaaBrowserForm()
        {
            InitializeComponent();

            this.categoriesComboBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            QueryItems = Functions.Search(this.queryInput.Text, this.categoriesComboBox.Text);
            this.resultBox.Items.Clear();
            LoadItems();
        }

        private void LoadItems()
        {
            this.resultBox.Items.Clear();

            foreach (FeedItem query in QueryItems)
            {
                this.resultBox.Items.Add(query.title);
            }
        }

        private void resultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox x = (ListBox)sender;
            int index = x.SelectedIndex;

            FeedItem selectedItem;

            if (index <= QueryItems.Count -1)
            {
                selectedItem = QueryItems[index];
                Form info = new ItemInformation(selectedItem);
                info.Show(this);
            }           
        }

        private void queryInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                searchButton.PerformClick();
            }
        }
    }
}
