using MetroFramework;
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
            this.btnGrabRocCDKey = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.manageCDKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.btnChangeTftKey = new MetroFramework.Controls.MetroButton();
            this.btnChangeRocKey = new MetroFramework.Controls.MetroButton();
            this.textBoxTftKey = new MetroFramework.Controls.MetroTextBox();
            this.textBoxRocKey = new MetroFramework.Controls.MetroTextBox();
            this.btnGrabTftCDKey = new MetroFramework.Controls.MetroButton();
            this.lblWarcraftVersion = new MetroFramework.Controls.MetroLabel();
            this.btnSetWarcraftPath = new MetroFramework.Controls.MetroButton();
            this.lblSetPath = new MetroFramework.Controls.MetroLabel();
            this.textBoxWarcraftPath = new MetroFramework.Controls.MetroTextBox();
            this.managePatchesGroupBox = new System.Windows.Forms.GroupBox();
            this.btnChangePatch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnManageSettings = new System.Windows.Forms.Button();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCDKeysGroupBox.SuspendLayout();
            this.managePatchesGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabRocCDKey
            // 
            this.btnGrabRocCDKey.Location = new System.Drawing.Point(30, 35);
            this.btnGrabRocCDKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabRocCDKey.Name = "btnGrabRocCDKey";
            this.btnGrabRocCDKey.Size = new System.Drawing.Size(119, 23);
            this.btnGrabRocCDKey.TabIndex = 8;
            this.btnGrabRocCDKey.Text = "Grab ROC CD Key";
            this.btnGrabRocCDKey.UseSelectable = true;
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
            this.btnChangeTftKey.Location = new System.Drawing.Point(402, 78);
            this.btnChangeTftKey.Name = "btnChangeTftKey";
            this.btnChangeTftKey.Size = new System.Drawing.Size(112, 23);
            this.btnChangeTftKey.TabIndex = 15;
            this.btnChangeTftKey.Text = "Change TFT Key";
            this.btnChangeTftKey.UseSelectable = true;
            this.btnChangeTftKey.Click += new System.EventHandler(this.btnChangeTftKey_Click);
            // 
            // btnChangeRocKey
            // 
            this.btnChangeRocKey.Location = new System.Drawing.Point(402, 35);
            this.btnChangeRocKey.Name = "btnChangeRocKey";
            this.btnChangeRocKey.Size = new System.Drawing.Size(112, 23);
            this.btnChangeRocKey.TabIndex = 14;
            this.btnChangeRocKey.Text = "Change ROC Key";
            this.btnChangeRocKey.UseSelectable = true;
            this.btnChangeRocKey.Click += new System.EventHandler(this.btnChangeRocKey_Click);
            // 
            // textBoxTftKey
            // 
            // 
            // 
            // 
            this.textBoxTftKey.CustomButton.Image = null;
            this.textBoxTftKey.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.textBoxTftKey.CustomButton.Name = "";
            this.textBoxTftKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxTftKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTftKey.CustomButton.TabIndex = 1;
            this.textBoxTftKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTftKey.CustomButton.UseSelectable = true;
            this.textBoxTftKey.CustomButton.Visible = false;
            this.textBoxTftKey.Lines = new string[0];
            this.textBoxTftKey.Location = new System.Drawing.Point(163, 78);
            this.textBoxTftKey.MaxLength = 32767;
            this.textBoxTftKey.Name = "textBoxTftKey";
            this.textBoxTftKey.PasswordChar = '\0';
            this.textBoxTftKey.PromptText = "Type a TFT Key and click on change";
            this.textBoxTftKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTftKey.SelectedText = "";
            this.textBoxTftKey.SelectionLength = 0;
            this.textBoxTftKey.SelectionStart = 0;
            this.textBoxTftKey.ShortcutsEnabled = true;
            this.textBoxTftKey.Size = new System.Drawing.Size(223, 23);
            this.textBoxTftKey.TabIndex = 13;
            this.textBoxTftKey.UseSelectable = true;
            this.textBoxTftKey.WaterMark = "Type a TFT Key and click on change";
            this.textBoxTftKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTftKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxRocKey
            // 
            // 
            // 
            // 
            this.textBoxRocKey.CustomButton.Image = null;
            this.textBoxRocKey.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.textBoxRocKey.CustomButton.Name = "";
            this.textBoxRocKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxRocKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxRocKey.CustomButton.TabIndex = 1;
            this.textBoxRocKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxRocKey.CustomButton.UseSelectable = true;
            this.textBoxRocKey.CustomButton.Visible = false;
            this.textBoxRocKey.Lines = new string[0];
            this.textBoxRocKey.Location = new System.Drawing.Point(163, 35);
            this.textBoxRocKey.MaxLength = 32767;
            this.textBoxRocKey.Name = "textBoxRocKey";
            this.textBoxRocKey.PasswordChar = '\0';
            this.textBoxRocKey.PromptText = "Type a ROC Key and click on change";
            this.textBoxRocKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRocKey.SelectedText = "";
            this.textBoxRocKey.SelectionLength = 0;
            this.textBoxRocKey.SelectionStart = 0;
            this.textBoxRocKey.ShortcutsEnabled = true;
            this.textBoxRocKey.Size = new System.Drawing.Size(223, 23);
            this.textBoxRocKey.TabIndex = 12;
            this.textBoxRocKey.UseSelectable = true;
            this.textBoxRocKey.WaterMark = "Type a ROC Key and click on change";
            this.textBoxRocKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxRocKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGrabTftCDKey
            // 
            this.btnGrabTftCDKey.Location = new System.Drawing.Point(30, 78);
            this.btnGrabTftCDKey.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabTftCDKey.Name = "btnGrabTftCDKey";
            this.btnGrabTftCDKey.Size = new System.Drawing.Size(119, 23);
            this.btnGrabTftCDKey.TabIndex = 9;
            this.btnGrabTftCDKey.Text = "Grab TFT CD Key";
            this.btnGrabTftCDKey.UseSelectable = true;
            this.btnGrabTftCDKey.Click += new System.EventHandler(this.btnGrabTftCDKey_Click);
            // 
            // lblWarcraftVersion
            // 
            this.lblWarcraftVersion.AutoSize = true;
            this.lblWarcraftVersion.BackColor = System.Drawing.Color.LightGray;
            this.lblWarcraftVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblWarcraftVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarcraftVersion.Location = new System.Drawing.Point(6, 135);
            this.lblWarcraftVersion.Name = "lblWarcraftVersion";
            this.lblWarcraftVersion.Size = new System.Drawing.Size(208, 19);
            this.lblWarcraftVersion.TabIndex = 13;
            this.lblWarcraftVersion.Text = "Current Warcraft III version is ";
            this.lblWarcraftVersion.UseCustomForeColor = true;
            // 
            // btnSetWarcraftPath
            // 
            this.btnSetWarcraftPath.Location = new System.Drawing.Point(276, 51);
            this.btnSetWarcraftPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetWarcraftPath.Name = "btnSetWarcraftPath";
            this.btnSetWarcraftPath.Size = new System.Drawing.Size(27, 23);
            this.btnSetWarcraftPath.TabIndex = 10;
            this.btnSetWarcraftPath.Text = "...";
            this.btnSetWarcraftPath.UseSelectable = true;
            this.btnSetWarcraftPath.Click += new System.EventHandler(this.btnSetWarcraftPath_Click);
            // 
            // lblSetPath
            // 
            this.lblSetPath.AutoSize = true;
            this.lblSetPath.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSetPath.Location = new System.Drawing.Point(30, 29);
            this.lblSetPath.Name = "lblSetPath";
            this.lblSetPath.Size = new System.Drawing.Size(142, 19);
            this.lblSetPath.TabIndex = 12;
            this.lblSetPath.Text = "Set Warcraft III path";
            // 
            // textBoxWarcraftPath
            // 
            // 
            // 
            // 
            this.textBoxWarcraftPath.CustomButton.Image = null;
            this.textBoxWarcraftPath.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.textBoxWarcraftPath.CustomButton.Name = "";
            this.textBoxWarcraftPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxWarcraftPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxWarcraftPath.CustomButton.TabIndex = 1;
            this.textBoxWarcraftPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxWarcraftPath.CustomButton.UseSelectable = true;
            this.textBoxWarcraftPath.CustomButton.Visible = false;
            this.textBoxWarcraftPath.Lines = new string[0];
            this.textBoxWarcraftPath.Location = new System.Drawing.Point(30, 51);
            this.textBoxWarcraftPath.MaxLength = 32767;
            this.textBoxWarcraftPath.Name = "textBoxWarcraftPath";
            this.textBoxWarcraftPath.PasswordChar = '\0';
            this.textBoxWarcraftPath.ReadOnly = true;
            this.textBoxWarcraftPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxWarcraftPath.SelectedText = "";
            this.textBoxWarcraftPath.SelectionLength = 0;
            this.textBoxWarcraftPath.SelectionStart = 0;
            this.textBoxWarcraftPath.ShortcutsEnabled = true;
            this.textBoxWarcraftPath.Size = new System.Drawing.Size(241, 23);
            this.textBoxWarcraftPath.TabIndex = 11;
            this.textBoxWarcraftPath.UseSelectable = true;
            this.textBoxWarcraftPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxWarcraftPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnChangePatch.Location = new System.Drawing.Point(30, 90);
            this.btnChangePatch.Name = "btnChangePatch";
            this.btnChangePatch.Size = new System.Drawing.Size(118, 29);
            this.btnChangePatch.TabIndex = 15;
            this.btnChangePatch.Text = "Change patch";
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
            // btnManageSettings
            // 
            this.btnManageSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSettings.Location = new System.Drawing.Point(41, 356);
            this.btnManageSettings.Name = "btnManageSettings";
            this.btnManageSettings.Size = new System.Drawing.Size(220, 34);
            this.btnManageSettings.TabIndex = 16;
            this.btnManageSettings.Text = "Manage Warcraft III settings";
            this.btnManageSettings.UseVisualStyleBackColor = true;
            this.btnManageSettings.Click += new System.EventHandler(this.btnManageSettings_Click);
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
            this.managePatchesGroupBox.ResumeLayout(false);
            this.managePatchesGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnGrabRocCDKey;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox manageCDKeysGroupBox;
        private MetroFramework.Controls.MetroButton btnGrabTftCDKey;
        private MetroFramework.Controls.MetroTextBox textBoxRocKey;
        private MetroFramework.Controls.MetroTextBox textBoxTftKey;
        private MetroFramework.Controls.MetroButton btnChangeTftKey;
        private MetroFramework.Controls.MetroButton btnChangeRocKey;
        private MetroFramework.Controls.MetroLabel lblWarcraftVersion;
        private MetroFramework.Controls.MetroButton btnSetWarcraftPath;
        private MetroFramework.Controls.MetroLabel lblSetPath;
        private MetroFramework.Controls.MetroTextBox textBoxWarcraftPath;
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

