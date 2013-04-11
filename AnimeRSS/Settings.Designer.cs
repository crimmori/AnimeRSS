namespace AnimeRSS
{
    partial class Settings
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
            this.formattingSetting = new System.Windows.Forms.CheckBox();
            this.hashSetting = new System.Windows.Forms.CheckBox();
            this.daySetting = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshSetting = new System.Windows.Forms.TextBox();
            this.showOnTaskbarSetting = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontButton = new System.Windows.Forms.Button();
            this.fontSetting = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.removeLowresSetting = new System.Windows.Forms.CheckBox();
            this.toolTipSetting = new System.Windows.Forms.CheckBox();
            this.removeMess = new System.Windows.Forms.CheckBox();
            this.backGroundColorSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // formattingSetting
            // 
            this.formattingSetting.AutoSize = true;
            this.formattingSetting.Location = new System.Drawing.Point(12, 12);
            this.formattingSetting.Name = "formattingSetting";
            this.formattingSetting.Size = new System.Drawing.Size(75, 17);
            this.formattingSetting.TabIndex = 0;
            this.formattingSetting.Text = "Formatting";
            this.formattingSetting.UseVisualStyleBackColor = true;
            this.formattingSetting.CheckedChanged += new System.EventHandler(this.formattingSetting_CheckedChanged);
            // 
            // hashSetting
            // 
            this.hashSetting.AutoSize = true;
            this.hashSetting.Location = new System.Drawing.Point(12, 35);
            this.hashSetting.Name = "hashSetting";
            this.hashSetting.Size = new System.Drawing.Size(120, 17);
            this.hashSetting.TabIndex = 1;
            this.hashSetting.Text = "CRC32(hash) hiding";
            this.hashSetting.UseVisualStyleBackColor = true;
            this.hashSetting.CheckedChanged += new System.EventHandler(this.hashSetting_CheckedChanged);
            // 
            // daySetting
            // 
            this.daySetting.AutoSize = true;
            this.daySetting.Location = new System.Drawing.Point(12, 58);
            this.daySetting.Name = "daySetting";
            this.daySetting.Size = new System.Drawing.Size(121, 17);
            this.daySetting.TabIndex = 2;
            this.daySetting.Text = "Prefix items with day";
            this.daySetting.UseVisualStyleBackColor = true;
            this.daySetting.CheckedChanged += new System.EventHandler(this.daySetting_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Refresh rate (minutes)";
            // 
            // refreshSetting
            // 
            this.refreshSetting.Location = new System.Drawing.Point(125, 75);
            this.refreshSetting.Name = "refreshSetting";
            this.refreshSetting.Size = new System.Drawing.Size(55, 20);
            this.refreshSetting.TabIndex = 4;
            this.refreshSetting.TextChanged += new System.EventHandler(this.refreshSetting_TextChanged);
            // 
            // showOnTaskbarSetting
            // 
            this.showOnTaskbarSetting.AutoSize = true;
            this.showOnTaskbarSetting.Location = new System.Drawing.Point(12, 94);
            this.showOnTaskbarSetting.Name = "showOnTaskbarSetting";
            this.showOnTaskbarSetting.Size = new System.Drawing.Size(106, 17);
            this.showOnTaskbarSetting.TabIndex = 5;
            this.showOnTaskbarSetting.Text = "Show on taskbar";
            this.showOnTaskbarSetting.UseVisualStyleBackColor = true;
            this.showOnTaskbarSetting.CheckedChanged += new System.EventHandler(this.showOnTaskbarSetting_CheckedChanged);
            // 
            // fontButton
            // 
            this.fontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fontButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.fontButton.FlatAppearance.BorderSize = 0;
            this.fontButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.fontButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.fontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontButton.Location = new System.Drawing.Point(109, 247);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(71, 23);
            this.fontButton.TabIndex = 6;
            this.fontButton.Text = "Font color";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // fontSetting
            // 
            this.fontSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSetting.FlatAppearance.BorderSize = 0;
            this.fontSetting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.fontSetting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.fontSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontSetting.Location = new System.Drawing.Point(28, 247);
            this.fontSetting.Name = "fontSetting";
            this.fontSetting.Size = new System.Drawing.Size(75, 23);
            this.fontSetting.TabIndex = 7;
            this.fontSetting.Text = "Font";
            this.fontSetting.UseVisualStyleBackColor = true;
            this.fontSetting.Click += new System.EventHandler(this.fontSetting_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max items";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(69, 112);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // removeLowresSetting
            // 
            this.removeLowresSetting.AutoSize = true;
            this.removeLowresSetting.Location = new System.Drawing.Point(12, 138);
            this.removeLowresSetting.Name = "removeLowresSetting";
            this.removeLowresSetting.Size = new System.Drawing.Size(180, 17);
            this.removeLowresSetting.TabIndex = 10;
            this.removeLowresSetting.Text = "Remove lowres (360p and 480p)";
            this.removeLowresSetting.UseVisualStyleBackColor = true;
            this.removeLowresSetting.CheckedChanged += new System.EventHandler(this.removeLowresSetting_CheckedChanged);
            // 
            // toolTipSetting
            // 
            this.toolTipSetting.AutoSize = true;
            this.toolTipSetting.Location = new System.Drawing.Point(12, 161);
            this.toolTipSetting.Name = "toolTipSetting";
            this.toolTipSetting.Size = new System.Drawing.Size(108, 17);
            this.toolTipSetting.TabIndex = 11;
            this.toolTipSetting.Text = "Show info bubble";
            this.toolTipSetting.UseVisualStyleBackColor = true;
            this.toolTipSetting.CheckedChanged += new System.EventHandler(this.toolTipSetting_CheckedChanged);
            // 
            // removeMess
            // 
            this.removeMess.AutoSize = true;
            this.removeMess.Location = new System.Drawing.Point(12, 184);
            this.removeMess.Name = "removeMess";
            this.removeMess.Size = new System.Drawing.Size(142, 17);
            this.removeMess.TabIndex = 12;
            this.removeMess.Text = "Remove all \"[text]\" mess";
            this.removeMess.UseVisualStyleBackColor = true;
            this.removeMess.CheckedChanged += new System.EventHandler(this.removeMess_CheckedChanged);
            // 
            // backGroundColorSetting
            // 
            this.backGroundColorSetting.Location = new System.Drawing.Point(109, 218);
            this.backGroundColorSetting.Name = "backGroundColorSetting";
            this.backGroundColorSetting.Size = new System.Drawing.Size(71, 23);
            this.backGroundColorSetting.TabIndex = 13;
            this.backGroundColorSetting.Text = "BG color";
            this.backGroundColorSetting.UseVisualStyleBackColor = true;
            this.backGroundColorSetting.Click += new System.EventHandler(this.backGroundColorSetting_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 278);
            this.Controls.Add(this.backGroundColorSetting);
            this.Controls.Add(this.removeMess);
            this.Controls.Add(this.toolTipSetting);
            this.Controls.Add(this.removeLowresSetting);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontSetting);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.showOnTaskbarSetting);
            this.Controls.Add(this.refreshSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daySetting);
            this.Controls.Add(this.hashSetting);
            this.Controls.Add(this.formattingSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox formattingSetting;
        private System.Windows.Forms.CheckBox hashSetting;
        private System.Windows.Forms.CheckBox daySetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox refreshSetting;
        private System.Windows.Forms.CheckBox showOnTaskbarSetting;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button fontSetting;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox removeLowresSetting;
        private System.Windows.Forms.CheckBox toolTipSetting;
        private System.Windows.Forms.CheckBox removeMess;
        private System.Windows.Forms.Button backGroundColorSetting;

    }
}