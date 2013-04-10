namespace AnimeRSS.AutoDownloader
{
    partial class AutoDownloader
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.epRangeLabel = new System.Windows.Forms.Label();
            this.epFromNum = new System.Windows.Forms.NumericUpDown();
            this.epToLabel = new System.Windows.Forms.Label();
            this.epToNum = new System.Windows.Forms.NumericUpDown();
            this.feedLabel = new System.Windows.Forms.Label();
            this.feedCombobox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.autoDownloadList = new System.Windows.Forms.ListBox();
            this.deleteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.epFromNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epToNum)).BeginInit();
            this.deleteMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(84, 6);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(280, 20);
            this.titleTextbox.TabIndex = 1;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(12, 35);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.resolutionLabel.TabIndex = 2;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "360p",
            "480p",
            "720p",
            "1080p"});
            this.resolutionComboBox.Location = new System.Drawing.Point(84, 32);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(280, 21);
            this.resolutionComboBox.TabIndex = 3;
            // 
            // epRangeLabel
            // 
            this.epRangeLabel.AutoSize = true;
            this.epRangeLabel.Location = new System.Drawing.Point(12, 61);
            this.epRangeLabel.Name = "epRangeLabel";
            this.epRangeLabel.Size = new System.Drawing.Size(78, 13);
            this.epRangeLabel.TabIndex = 4;
            this.epRangeLabel.Text = "Episode range:";
            // 
            // epFromNum
            // 
            this.epFromNum.Location = new System.Drawing.Point(96, 59);
            this.epFromNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.epFromNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.epFromNum.Name = "epFromNum";
            this.epFromNum.Size = new System.Drawing.Size(50, 20);
            this.epFromNum.TabIndex = 5;
            this.epFromNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.epFromNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // epToLabel
            // 
            this.epToLabel.AutoSize = true;
            this.epToLabel.Location = new System.Drawing.Point(152, 61);
            this.epToLabel.Name = "epToLabel";
            this.epToLabel.Size = new System.Drawing.Size(16, 13);
            this.epToLabel.TabIndex = 6;
            this.epToLabel.Text = "to";
            // 
            // epToNum
            // 
            this.epToNum.Location = new System.Drawing.Point(174, 59);
            this.epToNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.epToNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.epToNum.Name = "epToNum";
            this.epToNum.Size = new System.Drawing.Size(50, 20);
            this.epToNum.TabIndex = 7;
            this.epToNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.epToNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // feedLabel
            // 
            this.feedLabel.AutoSize = true;
            this.feedLabel.Location = new System.Drawing.Point(15, 89);
            this.feedLabel.Name = "feedLabel";
            this.feedLabel.Size = new System.Drawing.Size(34, 13);
            this.feedLabel.TabIndex = 8;
            this.feedLabel.Text = "Feed:";
            // 
            // feedCombobox
            // 
            this.feedCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feedCombobox.FormattingEnabled = true;
            this.feedCombobox.Location = new System.Drawing.Point(84, 86);
            this.feedCombobox.Name = "feedCombobox";
            this.feedCombobox.Size = new System.Drawing.Size(280, 21);
            this.feedCombobox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 123);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(289, 123);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // autoDownloadList
            // 
            this.autoDownloadList.ContextMenuStrip = this.deleteMenu;
            this.autoDownloadList.FormattingEnabled = true;
            this.autoDownloadList.Location = new System.Drawing.Point(12, 152);
            this.autoDownloadList.Name = "autoDownloadList";
            this.autoDownloadList.Size = new System.Drawing.Size(352, 342);
            this.autoDownloadList.TabIndex = 12;
            this.autoDownloadList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.autoDownloadList_MouseDown);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // AutoDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 507);
            this.Controls.Add(this.autoDownloadList);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.feedCombobox);
            this.Controls.Add(this.feedLabel);
            this.Controls.Add(this.epToNum);
            this.Controls.Add(this.epToLabel);
            this.Controls.Add(this.epFromNum);
            this.Controls.Add(this.epRangeLabel);
            this.Controls.Add(this.resolutionComboBox);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AutoDownloader";
            this.Text = "AutoDownloader";
            ((System.ComponentModel.ISupportInitialize)(this.epFromNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epToNum)).EndInit();
            this.deleteMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.Label epRangeLabel;
        private System.Windows.Forms.NumericUpDown epFromNum;
        private System.Windows.Forms.Label epToLabel;
        private System.Windows.Forms.NumericUpDown epToNum;
        private System.Windows.Forms.Label feedLabel;
        private System.Windows.Forms.ComboBox feedCombobox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox autoDownloadList;
        private System.Windows.Forms.ContextMenuStrip deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}