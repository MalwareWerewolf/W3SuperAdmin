using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3SuperAdmin.BLL;

namespace W3SuperAdmin
{
    public partial class W3Settings : Form
    {
        private MainForm _mainForm;
        private SettingsFormBLL _settingsFormBll;
        private const string keyVideoName = "Video";
        private const string keySoundName = "Sound";
        private const string keyGameplayName = "Gameplay";
        private const string keyMiscName = "Misc";
        private const string keyStringName = "String";

        public W3Settings(MainForm mainForm, SettingsFormBLL settingsFormBll)
        {
            _mainForm = mainForm;
            _settingsFormBll = settingsFormBll;

            this.FormClosed += new FormClosedEventHandler(W3Settings_FormClosed);

            InitializeComponent();

            InitializeControlsProperties.TrackBars(groupBoxVideoSettings.Controls.OfType<TrackBar>());
            InitializeControlsProperties.TrackBars(groupBoxSoundSettings.Controls.OfType<TrackBar>());
            InitializeControlsProperties.TrackBars(groupBoxGameplaySettings.Controls.OfType<TrackBar>());
            _settingsFormBll.LoadForm(keyVideoName, keySoundName, keyGameplayName, keyMiscName, keyStringName,
                this.groupBoxVideoSettings, this.groupBoxSoundSettings, this.groupBoxGameplaySettings, this.textBoxCampaignProfile, this.textBoxUserLocal);
        }

        void W3Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Enabled = true;
            _mainForm.TopMost = true;
            _mainForm.TopMost = false;
        }

        private void returnToTheMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Enabled = true;
            _mainForm.TopMost = true;
            _mainForm.TopMost = false;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settingsFormBll.LoadForm(keyVideoName, keySoundName, keyGameplayName, keyMiscName, keyStringName,
                this.groupBoxVideoSettings, this.groupBoxSoundSettings, this.groupBoxGameplaySettings, this.textBoxCampaignProfile, this.textBoxUserLocal);
        }

        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settingsFormBll.UpdateRegistryKeys(keyVideoName, keySoundName, keyGameplayName, keyMiscName, keyStringName,
                this.groupBoxVideoSettings, this.groupBoxSoundSettings, this.groupBoxGameplaySettings, this.textBoxCampaignProfile, this.textBoxUserLocal);
        }

        private void trackBarGamma_Scroll(object sender, ScrollEventArgs e)
        {
            this.trackBarLabelGamma.Text = string.Concat(trackBarLabelGamma.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty), " ", this.trackBarGamma.Value.ToString(), "%");
        }

        private void trackBarSfxVolume_Scroll(object sender, ScrollEventArgs e)
        {
            this.trackBarLabelSfx_Volume.Text = string.Concat(trackBarLabelSfx_Volume.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarSFX_Volume.Value.ToString(), "%");
        }

        private void trackBarMusicVolume_Scroll(object sender, ScrollEventArgs e)
        {
            this.trackBarLabelMusic_Volume.Text = string.Concat(trackBarLabelMusic_Volume.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarMusic_Volume.Value.ToString(), "%");
        }

        private void trackBarKeyScroll_Scroll(object sender, ScrollEventArgs e)
        {
            this.trackBarLabelKey_Scroll.Text = string.Concat(trackBarLabelKey_Scroll.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarKey_Scroll.Value.ToString(), "%");
        }

        private void trackBarMouseScroll_Scroll(object sender, ScrollEventArgs e)
        {
            this.trackBarLabelMouse_Scroll.Text = string.Concat(trackBarLabelMouse_Scroll.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarMouse_Scroll.Value.ToString(), "%");
        }

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {
            this.trackBarLabelGamma.Text = string.Concat(trackBarLabelGamma.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty), " ", this.trackBarGamma.Value.ToString(), "%");
        }

        private void trackBarSFX_Volume_Scroll(object sender, EventArgs e)
        {
            this.trackBarLabelSfx_Volume.Text = string.Concat(trackBarLabelSfx_Volume.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarSFX_Volume.Value.ToString(), "%");
        }

        private void trackBarMusic_Volume_Scroll(object sender, EventArgs e)
        {
            this.trackBarLabelMusic_Volume.Text = string.Concat(trackBarLabelMusic_Volume.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarMusic_Volume.Value.ToString(), "%");
        }

        private void trackBarKey_Scroll_Scroll(object sender, EventArgs e)
        {
            this.trackBarLabelKey_Scroll.Text = string.Concat(trackBarLabelKey_Scroll.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarKey_Scroll.Value.ToString(), "%");
        }

        private void trackBarMouse_Scroll_Scroll(object sender, EventArgs e)
        {
            this.trackBarLabelMouse_Scroll.Text = string.Concat(trackBarLabelMouse_Scroll.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty)
                .Replace("_", " "), " ", this.trackBarMouse_Scroll.Value.ToString(), "%");
        }
    }
}
