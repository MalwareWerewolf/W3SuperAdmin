using W3SuperAdmin.BLL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace W3SuperAdmin
{
    public partial class MainForm : Form
    {
        private W3SuperAdminFormBLL w3SuperAdminFormBLL;

        private const string rocCDKeyFileName = "roc.w3k";
        private const string tftCDKeyFileName = "tft.w3k";
        private const string keyPath = @"Software\Blizzard Entertainment\Warcraft III";

        public MainForm()
        {
            InitializeComponent();
            LoadForm();
        }

        private void btnSetWarcraftPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxWarcraftPath.Text = folderBrowserDialog.SelectedPath;
                string location = Properties.Settings.Default.WarcraftLocation = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                w3SuperAdminFormBLL.UpdatePathAndButtonsState(location, lblWarcraftVersion.Name, btnChangePatch.Name, textBoxWarcraftPath.Name, btnGrabRocCDKey.Name, btnGrabTftCDKey.Name,
                    textBoxRocKey.Name, textBoxTftKey.Name, btnChangeRocKey.Name, btnChangeTftKey.Name);
                w3SuperAdminFormBLL.AddSubItemToPlay(location, playToolStripMenuItem);
            }
        }

        private void btnChangePatch_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form patchesForm = new PatchesForm(Properties.Settings.Default.WarcraftLocation, this, lblWarcraftVersion.Name, w3SuperAdminFormBLL);
            patchesForm.Show();
        }

        private void btnGrabRocCDKey_Click(object sender, EventArgs e)
        {
            w3SuperAdminFormBLL.GrabCDKey(rocCDKeyFileName, "Warcraft III Reign of Chaos CD Key");
        }

        private void btnGrabTftCDKey_Click(object sender, EventArgs e)
        {
            w3SuperAdminFormBLL.GrabCDKey(tftCDKeyFileName, "Warcraft III The Frozen Throne CD Key");
        }

        private void btnChangeRocKey_Click(object sender, EventArgs e)
        {
            w3SuperAdminFormBLL.ChangeCDKey(rocCDKeyFileName, textBoxRocKey.Name);
        }

        private void btnChangeTftKey_Click(object sender, EventArgs e)
        {
            w3SuperAdminFormBLL.ChangeCDKey(tftCDKeyFileName, textBoxTftKey.Name);
        }

        private void btnManageSettings_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            W3Settings settings = new W3Settings(this, new SettingsFormBLL(keyPath));
            settings.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm() {
            string location = Properties.Settings.Default.WarcraftLocation;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Blizzard Entertainment\Warcraft III");

            //check if the key exists
            if (key == null)
            {
                this.btnManageSettings.Enabled = false;
            }
            else
            {
                key.Dispose();
            }

            w3SuperAdminFormBLL = new W3SuperAdminFormBLL();
            w3SuperAdminFormBLL.PatchesGroupBox = this.managePatchesGroupBox;
            w3SuperAdminFormBLL.CDKeyGroupBox = this.manageCDKeysGroupBox;
            w3SuperAdminFormBLL.UpdatePathAndButtonsState(location, lblWarcraftVersion.Name, btnChangePatch.Name, 
                textBoxWarcraftPath.Name, btnGrabRocCDKey.Name, btnGrabTftCDKey.Name,
                textBoxRocKey.Name, textBoxTftKey.Name, btnChangeRocKey.Name, btnChangeTftKey.Name);
            w3SuperAdminFormBLL.AddSubItemToPlay(location, this.playToolStripMenuItem);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            About about = new About(this);
            about.Show();
        }
    }
}
