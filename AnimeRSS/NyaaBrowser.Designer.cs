namespace NyaaBrowser
{
    partial class NyaaBrowserForm
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
            this.queryInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // queryInput
            // 
            this.queryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryInput.BackColor = System.Drawing.SystemColors.Control;
            this.queryInput.Location = new System.Drawing.Point(13, 13);
            this.queryInput.Name = "queryInput";
            this.queryInput.Size = new System.Drawing.Size(341, 20);
            this.queryInput.TabIndex = 0;
            this.queryInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.queryInput_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(360, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.FormattingEnabled = true;
            this.resultBox.Location = new System.Drawing.Point(13, 40);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(422, 420);
            this.resultBox.TabIndex = 2;
            this.resultBox.SelectedIndexChanged += new System.EventHandler(this.resultBox_SelectedIndexChanged);
            // 
            // NyaaBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 472);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.queryInput);
            this.Name = "NyaaBrowserForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NyaaBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox resultBox;
    }
}

