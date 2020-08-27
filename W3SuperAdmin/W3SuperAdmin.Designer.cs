using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;

namespace W3SuperAdmin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGrabRocCDKey = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.manageCDKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.btnChangeTftKey = new System.Windows.Forms.Button();
            this.btnChangeRocKey = new System.Windows.Forms.Button();
            this.textBoxTftKey = new System.Windows.Forms.TextBox();
            this.textBoxRocKey = new System.Windows.Forms.TextBox();
            this.btnGrabTftCDKey = new System.Windows.Forms.Button();
            this.lblWarcraftVersion = new System.Windows.Forms.Label();
            this.btnSetWarcraftPath = new System.Windows.Forms.Button();
            this.lblSetPath = new System.Windows.Forms.Label();
            this.textBoxWarcraftPath = new System.Windows.Forms.TextBox();
            this.managePatchesGroupBox = new System.Windows.Forms.GroupBox();
            this.btnChangePatch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManageSettings = new System.Windows.Forms.Button();
            this.manageCDKeysGroupBox.SuspendLayout();
            this.managePatchesGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabRocCDKey
            // 
            this.btnGrabRocCDKey.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabRocCDKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabRocCDKey.Location = new System.Drawing.Point(30, 35);
            this.btnGrabRocCDKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabRocCDKey.Name = "btnGrabRocCDKey";
            this.btnGrabRocCDKey.Size = new System.Drawing.Size(119, 23);
            this.btnGrabRocCDKey.TabIndex = 8;
            this.btnGrabRocCDKey.Text = "Grab ROC CD Key";
            this.btnGrabRocCDKey.UseVisualStyleBackColor = false;
            this.btnGrabRocCDKey.Click += new System.EventHandler(this.btnGrabRocCDKey_Click);
            // 
            // manageCDKeysGroupBox
            // 
            this.manageCDKeysGroupBox.Controls.Add(this.btnChangeTftKey);
            this.manageCDKeysGroupBox.Controls.Add(this.btnChangeRocKey);
            this.manageCDKeysGroupBox.Controls.Add(this.textBoxTftKey);
            this.manageCDKeysGroupBox.Controls.Add(this.textBoxRocKey);
            this.manageCDKeysGroupBox.Controls.Add(this.btnGrabTftCDKey);
            this.manageCDKeysGroupBox.Controls.Add(this.btnGrabRocCDKey);
            this.manageCDKeysGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCDKeysGroupBox.Location = new System.Drawing.Point(11, 218);
            this.manageCDKeysGroupBox.Name = "manageCDKeysGroupBox";
            this.manageCDKeysGroupBox.Size = new System.Drawing.Size(537, 132);
            this.manageCDKeysGroupBox.TabIndex = 15;
            this.manageCDKeysGroupBox.TabStop = false;
            this.manageCDKeysGroupBox.Text = "Manage CD Keys (only working with 1.30 and 1.31)";
            // 
            // btnChangeTftKey
            // 
            this.btnChangeTftKey.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeTftKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTftKey.Location = new System.Drawing.Point(402, 78);
            this.btnChangeTftKey.Name = "btnChangeTftKey";
            this.btnChangeTftKey.Size = new System.Drawing.Size(112, 22);
            this.btnChangeTftKey.TabIndex = 15;
            this.btnChangeTftKey.Text = "Change TFT Key";
            this.btnChangeTftKey.UseVisualStyleBackColor = false;
            this.btnChangeTftKey.Click += new System.EventHandler(this.btnChangeTftKey_Click);
            // 
            // btnChangeRocKey
            // 
            this.btnChangeRocKey.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeRocKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRocKey.Location = new System.Drawing.Point(402, 35);
            this.btnChangeRocKey.Name = "btnChangeRocKey";
            this.btnChangeRocKey.Size = new System.Drawing.Size(112, 23);
            this.btnChangeRocKey.TabIndex = 14;
            this.btnChangeRocKey.Text = "Change ROC Key";
            this.btnChangeRocKey.UseVisualStyleBackColor = false;
            this.btnChangeRocKey.Click += new System.EventHandler(this.btnChangeRocKey_Click);
            // 
            // textBoxTftKey
            // 
            this.textBoxTftKey.Location = new System.Drawing.Point(163, 78);
            this.textBoxTftKey.Name = "textBoxTftKey";
            this.textBoxTftKey.Size = new System.Drawing.Size(223, 22);
            this.textBoxTftKey.TabIndex = 13;
            // 
            // textBoxRocKey
            // 
            this.textBoxRocKey.Location = new System.Drawing.Point(163, 35);
            this.textBoxRocKey.Name = "textBoxRocKey";
            this.textBoxRocKey.Size = new System.Drawing.Size(223, 22);
            this.textBoxRocKey.TabIndex = 12;
            // 
            // btnGrabTftCDKey
            // 
            this.btnGrabTftCDKey.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabTftCDKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabTftCDKey.Location = new System.Drawing.Point(30, 78);
            this.btnGrabTftCDKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabTftCDKey.Name = "btnGrabTftCDKey";
            this.btnGrabTftCDKey.Size = new System.Drawing.Size(119, 23);
            this.btnGrabTftCDKey.TabIndex = 9;
            this.btnGrabTftCDKey.Text = "Grab TFT CD Key";
            this.btnGrabTftCDKey.UseVisualStyleBackColor = false;
            this.btnGrabTftCDKey.Click += new System.EventHandler(this.btnGrabTftCDKey_Click);
            // 
            // lblWarcraftVersion
            // 
            this.lblWarcraftVersion.AutoSize = true;
            this.lblWarcraftVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblWarcraftVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarcraftVersion.Location = new System.Drawing.Point(6, 135);
            this.lblWarcraftVersion.Name = "lblWarcraftVersion";
            this.lblWarcraftVersion.Size = new System.Drawing.Size(178, 16);
            this.lblWarcraftVersion.TabIndex = 13;
            this.lblWarcraftVersion.Text = "Current Warcraft III version is ";
            // 
            // btnSetWarcraftPath
            // 
            this.btnSetWarcraftPath.Location = new System.Drawing.Point(276, 51);
            this.btnSetWarcraftPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetWarcraftPath.Name = "btnSetWarcraftPath";
            this.btnSetWarcraftPath.Size = new System.Drawing.Size(27, 23);
            this.btnSetWarcraftPath.TabIndex = 10;
            this.btnSetWarcraftPath.Text = "...";
            this.btnSetWarcraftPath.Click += new System.EventHandler(this.btnSetWarcraftPath_Click);
            // 
            // lblSetPath
            // 
            this.lblSetPath.AutoSize = true;
            this.lblSetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPath.Location = new System.Drawing.Point(30, 29);
            this.lblSetPath.Name = "lblSetPath";
            this.lblSetPath.Size = new System.Drawing.Size(143, 16);
            this.lblSetPath.TabIndex = 12;
            this.lblSetPath.Text = "Set Warcraft III path";
            // 
            // textBoxWarcraftPath
            // 
            this.textBoxWarcraftPath.BackColor = System.Drawing.Color.White;
            this.textBoxWarcraftPath.Location = new System.Drawing.Point(30, 51);
            this.textBoxWarcraftPath.Name = "textBoxWarcraftPath";
            this.textBoxWarcraftPath.ReadOnly = true;
            this.textBoxWarcraftPath.Size = new System.Drawing.Size(241, 22);
            this.textBoxWarcraftPath.TabIndex = 11;
            // 
            // managePatchesGroupBox
            // 
            this.managePatchesGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.managePatchesGroupBox.Controls.Add(this.btnChangePatch);
            this.managePatchesGroupBox.Controls.Add(this.textBoxWarcraftPath);
            this.managePatchesGroupBox.Controls.Add(this.lblSetPath);
            this.managePatchesGroupBox.Controls.Add(this.btnSetWarcraftPath);
            this.managePatchesGroupBox.Controls.Add(this.lblWarcraftVersion);
            this.managePatchesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePatchesGroupBox.Location = new System.Drawing.Point(12, 32);
            this.managePatchesGroupBox.Name = "managePatchesGroupBox";
            this.managePatchesGroupBox.Size = new System.Drawing.Size(537, 178);
            this.managePatchesGroupBox.TabIndex = 15;
            this.managePatchesGroupBox.TabStop = false;
            this.managePatchesGroupBox.Text = "Manage patches";
            // 
            // btnChangePatch
            // 
            this.btnChangePatch.Font = new System.Drawing.Font("Miriam CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnChangePatch.Image = global::W3SuperAdmin.Properties.Resources.Open_16x;
            this.btnChangePatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePatch.Location = new System.Drawing.Point(30, 90);
            this.btnChangePatch.Name = "btnChangePatch";
            this.btnChangePatch.Size = new System.Drawing.Size(118, 29);
            this.btnChangePatch.TabIndex = 15;
            this.btnChangePatch.Text = "Change patch";
            this.btnChangePatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePatch.UseVisualStyleBackColor = true;
            this.btnChangePatch.Click += new System.EventHandler(this.btnChangePatch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Run_16x;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Refresh_grey_16x;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.StatusInformation_12x_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Close_red_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnManageSettings
            // 
            this.btnManageSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSettings.Image = global::W3SuperAdmin.Properties.Resources.Open_16x;
            this.btnManageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSettings.Location = new System.Drawing.Point(41, 356);
            this.btnManageSettings.Name = "btnManageSettings";
            this.btnManageSettings.Size = new System.Drawing.Size(209, 34);
            this.btnManageSettings.TabIndex = 16;
            this.btnManageSettings.Text = "Manage Warcraft III settings";
            this.btnManageSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageSettings.UseVisualStyleBackColor = true;
            this.btnManageSettings.Click += new System.EventHandler(this.btnManageSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 412);
            this.Controls.Add(this.btnManageSettings);
            this.Controls.Add(this.manageCDKeysGroupBox);
            this.Controls.Add(this.managePatchesGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warcraft III Super Admin";
            this.manageCDKeysGroupBox.ResumeLayout(false);
            this.manageCDKeysGroupBox.PerformLayout();
            this.managePatchesGroupBox.ResumeLayout(false);
            this.managePatchesGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGrabRocCDKey;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox manageCDKeysGroupBox;
        private System.Windows.Forms.Button btnGrabTftCDKey;
        private System.Windows.Forms.TextBox textBoxRocKey;
        private System.Windows.Forms.TextBox textBoxTftKey;
        private System.Windows.Forms.Button btnChangeTftKey;
        private System.Windows.Forms.Button btnChangeRocKey;
        private System.Windows.Forms.Label lblWarcraftVersion;
        private System.Windows.Forms.Button btnSetWarcraftPath;
        private System.Windows.Forms.Label lblSetPath;
        private System.Windows.Forms.TextBox textBoxWarcraftPath;
        private System.Windows.Forms.GroupBox managePatchesGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnChangePatch;
        private System.Windows.Forms.Button btnManageSettings;
    }
}

