namespace NyaaBrowser
{
    partial class ItemInformation
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.seedsLabel = new System.Windows.Forms.Label();
            this.peersLabel = new System.Windows.Forms.Label();
            this.downloadsLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.openInBrowserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title: ";
            // 
            // seedsLabel
            // 
            this.seedsLabel.AutoSize = true;
            this.seedsLabel.Location = new System.Drawing.Point(13, 83);
            this.seedsLabel.Name = "seedsLabel";
            this.seedsLabel.Size = new System.Drawing.Size(52, 13);
            this.seedsLabel.TabIndex = 1;
            this.seedsLabel.Text = "Seeders: ";
            // 
            // peersLabel
            // 
            this.peersLabel.AutoSize = true;
            this.peersLabel.Location = new System.Drawing.Point(166, 83);
            this.peersLabel.Name = "peersLabel";
            this.peersLabel.Size = new System.Drawing.Size(57, 13);
            this.peersLabel.TabIndex = 2;
            this.peersLabel.Text = "Leechers: ";
            // 
            // downloadsLabel
            // 
            this.downloadsLabel.AutoSize = true;
            this.downloadsLabel.Location = new System.Drawing.Point(13, 105);
            this.downloadsLabel.Name = "downloadsLabel";
            this.downloadsLabel.Size = new System.Drawing.Size(66, 13);
            this.downloadsLabel.TabIndex = 3;
            this.downloadsLabel.Text = "Downloads: ";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(166, 105);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(33, 13);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "Size: ";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 35);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 13);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 58);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date: ";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(16, 129);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 7;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // openInBrowserButton
            // 
            this.openInBrowserButton.Location = new System.Drawing.Point(97, 129);
            this.openInBrowserButton.Name = "openInBrowserButton";
            this.openInBrowserButton.Size = new System.Drawing.Size(115, 23);
            this.openInBrowserButton.TabIndex = 8;
            this.openInBrowserButton.Text = "Open in browser";
            this.openInBrowserButton.UseVisualStyleBackColor = true;
            this.openInBrowserButton.Click += new System.EventHandler(this.openInBrowserButton_Click);
            // 
            // ItemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 160);
            this.Controls.Add(this.openInBrowserButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.downloadsLabel);
            this.Controls.Add(this.peersLabel);
            this.Controls.Add(this.seedsLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemInformation";
            this.Text = "ItemInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label seedsLabel;
        private System.Windows.Forms.Label peersLabel;
        private System.Windows.Forms.Label downloadsLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button openInBrowserButton;
    }
}