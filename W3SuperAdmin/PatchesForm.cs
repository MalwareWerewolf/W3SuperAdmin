using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3SuperAdmin.BLL;

namespace W3SuperAdmin
{
    public partial class PatchesForm : Form
    {
        private string patchesDir = Directory.GetCurrentDirectory() + "\\Patches";
        private string _location;
        private Form _mainForm;
        private string _lblWarcraftVersionName;
        private W3SuperAdminFormBLL _configurationBLL;
        private string message;
        private string title;
        private MessageBoxButtons buttons;

        public PatchesForm(string location, Form mainForm, string lblWarcraftVersionName, W3SuperAdminFormBLL configurationBLL)
        {
            _location = location;
            _mainForm = mainForm;
            _lblWarcraftVersionName = lblWarcraftVersionName;
            _configurationBLL = configurationBLL;

            InitializeComponent();
        }

        private void PatchesForm_Load(object sender, EventArgs e)
        {
            patchesList.Sorting = SortOrder.Ascending;
            this.FormClosed += new FormClosedEventHandler(PatchesForm_FormClosed);

            if (!Directory.Exists(patchesDir))
            {
                Directory.CreateDirectory(patchesDir);
            }

            DirectoryInfo d = new DirectoryInfo(patchesDir);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.zip"); //Getting zip files

            foreach (FileInfo file in Files)
            {
                ListViewItem listViewItem = new ListViewItem(file.Name);
                patchesList.Items.Add(listViewItem);
            }
        }

        private void addPatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPatchDialog.Filter = "zip files (*.zip)|*.zip";
            addPatchDialog.FilterIndex = 1;
            addPatchDialog.CheckFileExists = true;
            addPatchDialog.CheckPathExists = true;
            addPatchDialog.Multiselect = false;

            if (addPatchDialog.ShowDialog() == DialogResult.OK)
            {
                if (patchesList.Items.ContainsKey(addPatchDialog.FileName)) {
                    message = "The selected patch already exists, check if file name is correct and import the file again.";
                    title = "Exception thrown!";

                    buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    return;
                }

                ListViewItem listViewItem = new ListViewItem(addPatchDialog.SafeFileName);
                patchesList.Items.Add(listViewItem);

                File.Move(addPatchDialog.FileName, patchesDir + "\\" + addPatchDialog.SafeFileName);
                SavePatchVersion.Enabled = true;

                message = "The patch has been added successfully!";
                title = "Operation completed";

                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            }
        }

        private void SavePatchVersion_Click(object sender, EventArgs e)
        {
            string patchVersion = patchesList.FocusedItem != null ? patchesList.Items[patchesList.FocusedItem.Index].Text : null;

            if (patchVersion == null) {
                message = "Add a patch and select it from the list.";
                title = "Operation failed";

                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                return;
            }

            DirectoryInfo d = new DirectoryInfo(patchesDir);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.zip"); //Getting zip files
            foreach (FileInfo file in Files)
            {
                if (file.Name == patchVersion) {
                    using (ZipArchive archive = ZipFile.OpenRead(file.FullName))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            entry.ExtractToFile(Path.Combine(_location, entry.FullName), true);
                        }
                    }
                    Control lblWarcraftVersion = _configurationBLL.GetFormControl(_lblWarcraftVersionName, _mainForm);
                    _configurationBLL.UpdatePathAndButtonsState(_location, _lblWarcraftVersionName);

                    message = "The patch has been applied successfully!";
                    title = "Operation completed";

                    buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void removeSelectedPatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = patchesList.FocusedItem.Index;
            string patchVersion = patchesList.Items[index].Text;

            DirectoryInfo d = new DirectoryInfo(patchesDir);
            FileInfo[] Files = d.GetFiles("*.zip"); //Getting zip files
            foreach (FileInfo file in Files)
            {
                if (file.Name == patchVersion)
                {
                    File.Delete(file.FullName);
                    patchesList.Items.RemoveAt(index);

                    message = "Patch deleted successfully!";
                    title = "Operation completed";

                    buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void returnToTheMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Enabled = true;
            _mainForm.TopMost = true;
            _mainForm.TopMost = false;
        }

        void PatchesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Enabled = true;
            _mainForm.TopMost = true;
            _mainForm.TopMost = false;
        }
    }
}
