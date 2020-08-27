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
    public partial class About : Form
    {
        private MainForm _mainForm;

        public About(MainForm mainForm)
        {
            _mainForm = mainForm;

            this.FormClosed += new FormClosedEventHandler(PatchesForm_FormClosed);

            InitializeComponent();
        }

        void PatchesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Enabled = true;
            _mainForm.TopMost = true;
            _mainForm.TopMost = false;
        }

        private void gitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Cramenorn/W3SuperAdmin");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Enabled = true;
            _mainForm.TopMost = true;
            _mainForm.TopMost = false;
        }
    }
}
