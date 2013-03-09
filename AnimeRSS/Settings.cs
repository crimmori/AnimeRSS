using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeRSS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.formattingSetting.Checked = WindowForm.formattingEnabled;
            this.hashSetting.Checked = WindowForm.hashHidingEnabled;
            this.daySetting.Checked = WindowForm.prefixItemDate;
            this.refreshSetting.Text = Convert.ToString(WindowForm.refreshRate / 60000);
            this.showOnTaskbarSetting.Checked = WindowForm.showOnTaskbar;
            this.numericUpDown1.Value = WindowForm.maxItems;
            this.removeLowresSetting.Checked = WindowForm.removeLowres;
            this.toolTipSetting.Checked = WindowForm.showToolTip;
        }

        private void formattingSetting_CheckedChanged(object sender, EventArgs e)
        {
            WindowForm.formattingEnabled = this.formattingSetting.Checked;
        }

        private void hashSetting_CheckedChanged(object sender, EventArgs e)
        {
            WindowForm.hashHidingEnabled = this.hashSetting.Checked;
        }

        private void daySetting_CheckedChanged(object sender, EventArgs e)
        {
            WindowForm.prefixItemDate = this.daySetting.Checked;
        }

        private void refreshSetting_TextChanged(object sender, EventArgs e)
        {
            WindowForm.refreshRate = Convert.ToInt32(this.refreshSetting.Text) * 60000;
            
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void showOnTaskbarSetting_CheckedChanged(object sender, EventArgs e)
        {
            WindowForm.showOnTaskbar = this.showOnTaskbarSetting.Checked;
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);

            WindowForm.customFontColor = colorDialog1.Color;
        }

        private void fontSetting_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(this);
            WindowForm.customFont = fontDialog1.Font;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            WindowForm.maxItems = (int)numericUpDown1.Value;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void removeLowresSetting_CheckedChanged(object sender, EventArgs e)
        {
            WindowForm.removeLowres = this.removeLowresSetting.Checked;
        }

        private void toolTipSetting_CheckedChanged(object sender, EventArgs e)
        {
            WindowForm.showToolTip = this.toolTipSetting.Checked;
        }
    }
}
