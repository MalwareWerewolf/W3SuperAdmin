using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace W3SuperAdmin.BLL
{
    public class W3SuperAdminFormBLL
    {
        private string locationWar3Exe;
        private string locationFrozenThroneExe;
        private string locationWarcraftExe;
        private readonly string cdKeysLocation = Interaction.Environ("systemdrive") + @"\ProgramData\Blizzard Entertainment\Warcraft III\";

        public void UpdatePathAndButtonsState(string location, string lblWarcraftVersionName, string btnChangePatchName, string textBoxWarcraftPathName,
            string btnGrabRocCDKeyName, string btnGrabTftCDKeyName, string textBoxRocKeyName, string textBoxTftKeyName, string btnChangeRocKeyName, string btnChangeTftKeyName) 
        {
            Control lblWarcraftVersion = GetPanelControl(lblWarcraftVersionName, PatchesGroupBox);
            Control btnChangePatch = GetPanelControl(btnChangePatchName, PatchesGroupBox);
            Control btnGrabRocCDKey = GetPanelControl(btnGrabRocCDKeyName, CDKeyGroupBox);
            Control btnGrabTftCDKey = GetPanelControl(btnGrabTftCDKeyName, CDKeyGroupBox);
            Control textBoxRocKey = GetPanelControl(textBoxRocKeyName, CDKeyGroupBox);
            Control textBoxTftKey = GetPanelControl(textBoxTftKeyName, CDKeyGroupBox);
            Control btnChangeRocKey = GetPanelControl(btnChangeRocKeyName, CDKeyGroupBox);
            Control btnChangeTftKey = GetPanelControl(btnChangeTftKeyName, CDKeyGroupBox);

            //default buttons vibility
            btnChangePatch.Enabled = false;
            btnGrabRocCDKey.Enabled = false;
            btnGrabTftCDKey.Enabled = false;
            textBoxRocKey.Enabled = false;
            textBoxTftKey.Enabled = false;
            btnChangeRocKey.Enabled = false;
            btnChangeTftKey.Enabled = false;

            if (location == null || location.Equals(string.Empty) || !Directory.Exists(location))
            {
                lblWarcraftVersion.Text = "Warcraft III path is not set or is not valid";
            }
            else
            {
                locationWar3Exe = location + @"\war3.exe";
                locationFrozenThroneExe = location + @"\Frozen Throne.exe";
                locationWarcraftExe = location + @"\Warcraft III.exe";

                string lblWarcraftVersionText = "Current version is {0}";

                btnChangePatch.Enabled = true;

                if (File.Exists(locationWar3Exe))
                {
                    lblWarcraftVersion.Text = string.Format(lblWarcraftVersionText, FileVersionInfo.GetVersionInfo(locationWar3Exe)
                        .FileVersion.Replace(" ", string.Empty).Replace(",", "."));
                    lblWarcraftVersion.ForeColor = Color.Blue;
                }
                else if (File.Exists(locationFrozenThroneExe))
                {
                    lblWarcraftVersion.Text = string.Format(lblWarcraftVersionText, FileVersionInfo.GetVersionInfo(locationFrozenThroneExe)
                        .FileVersion.Replace(" ", string.Empty).Replace(",", "."));
                    lblWarcraftVersion.ForeColor = Color.Blue;
                }
                else if (File.Exists(locationWarcraftExe))
                {
                    lblWarcraftVersion.Text = string.Format(lblWarcraftVersionText, FileVersionInfo.GetVersionInfo(locationWarcraftExe)
                        .FileVersion.Replace(" ", string.Empty).Replace(",", "."));
                    lblWarcraftVersion.ForeColor = Color.Blue;

                    btnChangePatch.Enabled = false;
                    btnGrabRocCDKey.Enabled = true;
                    btnGrabTftCDKey.Enabled = true;
                    textBoxRocKey.Enabled = true;
                    textBoxTftKey.Enabled = true;
                    btnChangeRocKey.Enabled = true;
                    btnChangeTftKey.Enabled = true;
                }
                else
                {
                    lblWarcraftVersion.Text = "Unable to find war3.exe, Warcraft III.exe or Frozen Throne.exe in the folder";
                    
                    btnChangePatch.Enabled = false;
                    return;
                }

                Control textBoxWarcraftPath = GetPanelControl(textBoxWarcraftPathName, PatchesGroupBox);
                textBoxWarcraftPath.Text = location;
            }
        }

        public void UpdatePathAndButtonsState(string location, string lblWarcraftVersionName)
        {
            Control lblWarcraftVersion = GetPanelControl(lblWarcraftVersionName, PatchesGroupBox);

            if (location.Equals(string.Empty) || !Directory.Exists(location))
            {
                lblWarcraftVersion.Text = "Warcraft III path is not set or is not valid";
            }
            else
            {
                locationWar3Exe = location + @"\war3.exe";
                locationFrozenThroneExe = location + @"\Frozen Throne.exe";
                locationWarcraftExe = location + @"\Warcraft III.exe";

                string lblWarcraftVersionText = "Current version is {0}";

                if (File.Exists(locationWar3Exe))
                {
                    lblWarcraftVersion.Text = string.Format(lblWarcraftVersionText, FileVersionInfo.GetVersionInfo(locationWar3Exe)
                        .FileVersion.Replace(" ", string.Empty).Replace(",", "."));
                    lblWarcraftVersion.ForeColor = Color.Blue;
                }
                else if (File.Exists(locationFrozenThroneExe))
                {
                    lblWarcraftVersion.Text = string.Format(lblWarcraftVersionText, FileVersionInfo.GetVersionInfo(locationFrozenThroneExe)
                        .FileVersion.Replace(" ", string.Empty).Replace(",", "."));
                    lblWarcraftVersion.ForeColor = Color.Blue;
                }
                else if (File.Exists(locationWarcraftExe))
                {
                    lblWarcraftVersion.Text = string.Format(lblWarcraftVersionText, FileVersionInfo.GetVersionInfo(locationWarcraftExe)
                        .FileVersion.Replace(" ", string.Empty).Replace(",", "."));
                    lblWarcraftVersion.ForeColor = Color.Blue;
                }
                else
                {
                    lblWarcraftVersion.Text = "Unable to find war.exe, Warcraft III.exe or Frozen Throne.exe in the folder";
                    return;
                }
            }
        }

        public void AddSubItemToPlay(string location, ToolStripMenuItem playToolStripMenuItem) {
            locationWar3Exe = location + @"\war3.exe";
            locationFrozenThroneExe = location + @"\Frozen Throne.exe";
            locationWarcraftExe = location + @"\Warcraft III.exe";

            playToolStripMenuItem.DropDownItems.Clear();

            if (File.Exists(locationWar3Exe))
            {
                ToolStripMenuItem war3Item = new ToolStripMenuItem("Warcraft III: Reign of Chaos", null, delegate
                {
                    Process.Start(locationWarcraftExe);
                });
                playToolStripMenuItem.DropDownItems.Add(war3Item);

                if (File.Exists(locationFrozenThroneExe))
                {
                    ToolStripMenuItem frozenThroneItem = new ToolStripMenuItem("Warcraft III: The Frozen Throne", null, delegate
                    {
                        Process.Start(locationFrozenThroneExe);
                    });

                    playToolStripMenuItem.DropDownItems.Add(frozenThroneItem);
                }
            }            
            else if (File.Exists(locationWarcraftExe))
            {
                playToolStripMenuItem.DropDownItems.Clear();

                ToolStripMenuItem warcraft3Item = new ToolStripMenuItem("Warcraft III", null, delegate
                {
                    Process.Start(locationWarcraftExe);
                });

                playToolStripMenuItem.DropDownItems.Add(warcraft3Item);
            }
        }

        public void GrabCDKey(string fileName, string title) {
            string message;

            MessageBoxManager.OK = "Grab Key";
            MessageBoxManager.Register();

            try
            {
                string path = cdKeysLocation + fileName;
                StreamReader streamReader = new StreamReader(path);
                message = streamReader.ReadToEnd();

                if (MessageBox.Show(message, title, MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    Clipboard.SetText(message);
                }

                MessageBoxManager.Unregister();
            }
            catch (Exception)
            {
                MessageBoxManager.Unregister();
                message = "The CD Key could not be found, make sure that Warcraft III is installed correctly. Keep in mind that this button only works with the patches 1.30 and 1.31";
                title += " - Error";

                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
        }

        public void ChangeCDKey(string fileName, string textBoxKeyName) {
            string path = cdKeysLocation + fileName;
            string message;
            string title = "Warcraft III Super Admin";
            string regexPattern = @"^[A-Z0-9]+$";
            Control textBoxKey = GetPanelControl(textBoxKeyName, CDKeyGroupBox);

            try
            {
                if (textBoxKey.Text.Contains("-")) {
                    textBoxKey.Text = textBoxKey.Text.Replace("-", string.Empty);
                }

                if (textBoxKey.Text.Length != 26 || !Regex.IsMatch(textBoxKey.Text, regexPattern)) {
                    message = "Invalid CD key, it can only contain capital letters and numbers with a length equals to 26 characters.";
                    title += " - Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK);
                    return;
                }

                File.WriteAllText(path, textBoxKey.Text);

                message = "Key changed successfully.";
                textBoxKey.Text = string.Empty;

                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                message = "Something went wrong, try again the operation";
                title += " - Error";

                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
        }

        public Control GetFormControl(string controlName, Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.Name == controlName)
                    return control;
            }

            return null;
        }


        public GroupBox PatchesGroupBox { get; set; }
        public GroupBox CDKeyGroupBox { get; set; }

        private Control GetPanelControl(string controlName, GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control.Name == controlName)
                    return control;
            }

            return null;
        }
    }
}
