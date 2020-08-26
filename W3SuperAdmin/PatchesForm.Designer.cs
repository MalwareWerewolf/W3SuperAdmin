namespace W3SuperAdmin
{
    partial class PatchesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchesForm));
            this.SavePatchVersion = new MetroFramework.Controls.MetroButton();
            this.patchesList = new MetroFramework.Controls.MetroListView();
            this.PatchVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patchMenu = new System.Windows.Forms.MenuStrip();
            this.addPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToTheMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.addPatchDialog = new System.Windows.Forms.OpenFileDialog();
            this.patchMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SavePatchVersion
            // 
            this.SavePatchVersion.Location = new System.Drawing.Point(341, 269);
            this.SavePatchVersion.Name = "SavePatchVersion";
            this.SavePatchVersion.Size = new System.Drawing.Size(158, 23);
            this.SavePatchVersion.TabIndex = 20;
            this.SavePatchVersion.Text = "Apply selected patch version";
            this.SavePatchVersion.UseSelectable = true;
            this.SavePatchVersion.Click += new System.EventHandler(this.SavePatchVersion_Click);
            // 
            // patchesList
            // 
            this.patchesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatchVersion});
            this.patchesList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.patchesList.FullRowSelect = true;
            this.patchesList.Location = new System.Drawing.Point(12, 38);
            this.patchesList.MultiSelect = false;
            this.patchesList.Name = "patchesList";
            this.patchesList.OwnerDraw = true;
            this.patchesList.Size = new System.Drawing.Size(487, 212);
            this.patchesList.TabIndex = 18;
            this.patchesList.UseCompatibleStateImageBehavior = false;
            this.patchesList.UseSelectable = true;
            this.patchesList.View = System.Windows.Forms.View.Details;
            // 
            // PatchVersion
            // 
            this.PatchVersion.Text = "Patch version";
            this.PatchVersion.Width = 482;
            // 
            // patchMenu
            // 
            this.patchMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatchToolStripMenuItem,
            this.removeSelectedPatchToolStripMenuItem,
            this.returnToTheMainWindowToolStripMenuItem});
            this.patchMenu.Location = new System.Drawing.Point(0, 0);
            this.patchMenu.Name = "patchMenu";
            this.patchMenu.Size = new System.Drawing.Size(511, 24);
            this.patchMenu.TabIndex = 25;
            this.patchMenu.Text = "menuStrip1";
            // 
            // addPatchToolStripMenuItem
            // 
            this.addPatchToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Add_8x_16x;
            this.addPatchToolStripMenuItem.Name = "addPatchToolStripMenuItem";
            this.addPatchToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.addPatchToolStripMenuItem.Text = "Add patch";
            this.addPatchToolStripMenuItem.Click += new System.EventHandler(this.addPatchToolStripMenuItem_Click);
            // 
            // removeSelectedPatchToolStripMenuItem
            // 
            this.removeSelectedPatchToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Medium_228_16x;
            this.removeSelectedPatchToolStripMenuItem.Name = "removeSelectedPatchToolStripMenuItem";
            this.removeSelectedPatchToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.removeSelectedPatchToolStripMenuItem.Text = "Remove patch zip file";
            this.removeSelectedPatchToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedPatchToolStripMenuItem_Click);
            // 
            // returnToTheMainWindowToolStripMenuItem
            // 
            this.returnToTheMainWindowToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.GoToFirst_16x;
            this.returnToTheMainWindowToolStripMenuItem.Name = "returnToTheMainWindowToolStripMenuItem";
            this.returnToTheMainWindowToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.returnToTheMainWindowToolStripMenuItem.Text = "Return to the main window";
            this.returnToTheMainWindowToolStripMenuItem.Click += new System.EventHandler(this.returnToTheMainWindowToolStripMenuItem_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(12, 314);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(487, 23);
            this.metroProgressBar1.TabIndex = 26;
            // 
            // addPatchDialog
            // 
            this.addPatchDialog.FileName = "addPatchDialog";
            // 
            // PatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 369);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.patchMenu);
            this.Controls.Add(this.SavePatchVersion);
            this.Controls.Add(this.patchesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.patchMenu;
            this.MaximizeBox = false;
            this.Name = "PatchesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warcraft III Super Admin - Manage patches";
            this.Load += new System.EventHandler(this.PatchesForm_Load);
            this.patchMenu.ResumeLayout(false);
            this.patchMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SavePatchVersion;
        private MetroFramework.Controls.MetroListView patchesList;
        private System.Windows.Forms.MenuStrip patchMenu;
        private System.Windows.Forms.ToolStripMenuItem addPatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedPatchToolStripMenuItem;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.OpenFileDialog addPatchDialog;
        private System.Windows.Forms.ColumnHeader PatchVersion;
        private System.Windows.Forms.ToolStripMenuItem returnToTheMainWindowToolStripMenuItem;
    }
}