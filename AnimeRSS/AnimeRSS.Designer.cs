namespace AnimeRSS
{
    public partial class WindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowForm));
            this.FeedsTabs = new System.Windows.Forms.TabControl();
            this.MenuContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchNyaaToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDownloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshFeeds = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.itemTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeedsTabs
            // 
            this.FeedsTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.FeedsTabs.ContextMenuStrip = this.MenuContextStrip;
            this.FeedsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedsTabs.Location = new System.Drawing.Point(0, 0);
            this.FeedsTabs.Margin = new System.Windows.Forms.Padding(0);
            this.FeedsTabs.Name = "FeedsTabs";
            this.FeedsTabs.SelectedIndex = 0;
            this.FeedsTabs.Size = new System.Drawing.Size(340, 395);
            this.FeedsTabs.TabIndex = 0;
            this.FeedsTabs.SelectedIndexChanged += new System.EventHandler(this.FeedsTabs_SelectedIndexChanged);
            // 
            // MenuContextStrip
            // 
            this.MenuContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshStripMenuItem,
            this.searchNyaaToolStrip,
            this.newFeedToolStripMenuItem,
            this.deleteFeedToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.formattingToolStripMenuItem,
            this.autoDownloaderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuContextStrip.Name = "MenuContextStrip";
            this.MenuContextStrip.ShowImageMargin = false;
            this.MenuContextStrip.Size = new System.Drawing.Size(132, 180);
            // 
            // refreshStripMenuItem
            // 
            this.refreshStripMenuItem.Name = "refreshStripMenuItem";
            this.refreshStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.refreshStripMenuItem.Text = "Refresh";
            this.refreshStripMenuItem.Click += new System.EventHandler(this.refreshStripMenuItem_Click);
            // 
            // searchNyaaToolStrip
            // 
            this.searchNyaaToolStrip.Name = "searchNyaaToolStrip";
            this.searchNyaaToolStrip.Size = new System.Drawing.Size(131, 22);
            this.searchNyaaToolStrip.Text = "Search Nyaa";
            this.searchNyaaToolStrip.Click += new System.EventHandler(this.searchNyaaToolStrip_Click);
            // 
            // newFeedToolStripMenuItem
            // 
            this.newFeedToolStripMenuItem.Name = "newFeedToolStripMenuItem";
            this.newFeedToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newFeedToolStripMenuItem.Text = "New feed";
            this.newFeedToolStripMenuItem.Click += new System.EventHandler(this.newFeedToolStripMenuItem_Click);
            // 
            // deleteFeedToolStripMenuItem
            // 
            this.deleteFeedToolStripMenuItem.Name = "deleteFeedToolStripMenuItem";
            this.deleteFeedToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteFeedToolStripMenuItem.Text = "Delete feed";
            this.deleteFeedToolStripMenuItem.Click += new System.EventHandler(this.deleteFeedToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // formattingToolStripMenuItem
            // 
            this.formattingToolStripMenuItem.Name = "formattingToolStripMenuItem";
            this.formattingToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.formattingToolStripMenuItem.Text = "Formatting";
            this.formattingToolStripMenuItem.Click += new System.EventHandler(this.formattingToolStripMenuItem_Click);
            // 
            // autoDownloaderToolStripMenuItem
            // 
            this.autoDownloaderToolStripMenuItem.Name = "autoDownloaderToolStripMenuItem";
            this.autoDownloaderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.autoDownloaderToolStripMenuItem.Text = "Auto Downloader";
            this.autoDownloaderToolStripMenuItem.Click += new System.EventHandler(this.autoDownloaderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RefreshFeeds
            // 
            this.RefreshFeeds.Enabled = true;
            this.RefreshFeeds.Interval = 600000;
            this.RefreshFeeds.Tick += new System.EventHandler(this.RefreshFeeds_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Anime RSS";
            this.notifyIcon1.ContextMenuStrip = this.MenuContextStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Anime RSS";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // itemTooltip
            // 
            this.itemTooltip.AutomaticDelay = 60;
            this.itemTooltip.AutoPopDelay = 60;
            this.itemTooltip.BackColor = System.Drawing.SystemColors.Control;
            this.itemTooltip.InitialDelay = 60;
            this.itemTooltip.ReshowDelay = 12;
            this.itemTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 395);
            this.ContextMenuStrip = this.MenuContextStrip;
            this.ControlBox = false;
            this.Controls.Add(this.FeedsTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.MenuContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl FeedsTabs;
        private System.Windows.Forms.ContextMenuStrip MenuContextStrip;
        private System.Windows.Forms.ToolStripMenuItem newFeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formattingToolStripMenuItem;
        public System.Windows.Forms.Timer RefreshFeeds;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem deleteFeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshStripMenuItem;
        private System.Windows.Forms.ToolTip itemTooltip;
        private System.Windows.Forms.ToolStripMenuItem searchNyaaToolStrip;
        private System.Windows.Forms.ToolStripMenuItem autoDownloaderToolStripMenuItem;
    }
}

