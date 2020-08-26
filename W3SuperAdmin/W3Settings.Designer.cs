namespace W3SuperAdmin
{
    partial class W3Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W3Settings));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToTheMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxThreeOptionsLights = new System.Windows.Forms.ComboBox();
            this.lightsLabel = new MetroFramework.Controls.MetroLabel();
            this.particlesLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxThreeOptionsParticles = new System.Windows.Forms.ComboBox();
            this.animationQualityLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxThreeOptionsAnimQuality = new System.Windows.Forms.ComboBox();
            this.textureQualityLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxThreeOptionsTexQuality = new System.Windows.Forms.ComboBox();
            this.modelDetailLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxThreeOptionsModelDetail = new System.Windows.Forms.ComboBox();
            this.spellDetailLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxThreeOptionsSpellFilter = new System.Windows.Forms.ComboBox();
            this.occlusionLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxBoolOptionsOcclusion = new System.Windows.Forms.ComboBox();
            this.groupBoxVideoSettings = new System.Windows.Forms.GroupBox();
            this.trackBarLabelGamma = new MetroFramework.Controls.MetroLabel();
            this.trackBarGamma = new MetroFramework.Controls.MetroTrackBar();
            this.comboBoxBitOptionsTexColorDepth = new System.Windows.Forms.ComboBox();
            this.texColorDepthLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxWindowMode = new System.Windows.Forms.ComboBox();
            this.windowModeLabel = new MetroFramework.Controls.MetroLabel();
            this.vsyncLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxBoolOptionsVSync = new System.Windows.Forms.ComboBox();
            this.screenResolutionLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxScreenResolution = new System.Windows.Forms.ComboBox();
            this.unitShadowsLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxBoolOptionsUnitShadows = new System.Windows.Forms.ComboBox();
            this.groupBoxSoundSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxBoolOptionsSubtitles = new System.Windows.Forms.ComboBox();
            this.subtitlesLabel = new MetroFramework.Controls.MetroLabel();
            this.trackBarLabelMusic_Volume = new MetroFramework.Controls.MetroLabel();
            this.trackBarMusic_Volume = new MetroFramework.Controls.MetroTrackBar();
            this.trackBarLabelSfx_Volume = new MetroFramework.Controls.MetroLabel();
            this.trackBarSFX_Volume = new MetroFramework.Controls.MetroTrackBar();
            this.groupBoxGameplaySettings = new System.Windows.Forms.GroupBox();
            this.comboBoxBoolOptions_autosaveReplay = new System.Windows.Forms.ComboBox();
            this.autoSaveReplayLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxBoolOptionsCustomKeys = new System.Windows.Forms.ComboBox();
            this.customKeysLabel = new MetroFramework.Controls.MetroLabel();
            this.comboBoxBoolOptionsDisplayFps = new System.Windows.Forms.ComboBox();
            this.comboBoxBoolOptionsDisplayPing = new System.Windows.Forms.ComboBox();
            this.displayFpsLabel = new MetroFramework.Controls.MetroLabel();
            this.displayPingLabel = new MetroFramework.Controls.MetroLabel();
            this.trackBarLabelMouse_Scroll = new MetroFramework.Controls.MetroLabel();
            this.trackBarMouse_Scroll = new MetroFramework.Controls.MetroTrackBar();
            this.trackBarLabelKey_Scroll = new MetroFramework.Controls.MetroLabel();
            this.trackBarKey_Scroll = new MetroFramework.Controls.MetroTrackBar();
            this.textBoxCampaignProfile = new MetroFramework.Controls.MetroTextBox();
            this.campaignProfileLabel = new MetroFramework.Controls.MetroLabel();
            this.userLocalLabel = new MetroFramework.Controls.MetroLabel();
            this.textBoxUserLocal = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxVideoSettings.SuspendLayout();
            this.groupBoxSoundSettings.SuspendLayout();
            this.groupBoxGameplaySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.returnToTheMainWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Save_16x;
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.saveSettingsToolStripMenuItem.Text = "Save settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.Refresh_grey_16x;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // returnToTheMainWindowToolStripMenuItem
            // 
            this.returnToTheMainWindowToolStripMenuItem.Image = global::W3SuperAdmin.Properties.Resources.GoToFirst_16x;
            this.returnToTheMainWindowToolStripMenuItem.Name = "returnToTheMainWindowToolStripMenuItem";
            this.returnToTheMainWindowToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.returnToTheMainWindowToolStripMenuItem.Text = "Return to the main window";
            this.returnToTheMainWindowToolStripMenuItem.Click += new System.EventHandler(this.returnToTheMainWindowToolStripMenuItem_Click);
            // 
            // comboBoxThreeOptionsLights
            // 
            this.comboBoxThreeOptionsLights.BackColor = System.Drawing.Color.White;
            this.comboBoxThreeOptionsLights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeOptionsLights.FormattingEnabled = true;
            this.comboBoxThreeOptionsLights.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxThreeOptionsLights.Location = new System.Drawing.Point(138, 153);
            this.comboBoxThreeOptionsLights.Name = "comboBoxThreeOptionsLights";
            this.comboBoxThreeOptionsLights.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsLights.TabIndex = 1;
            // 
            // lightsLabel
            // 
            this.lightsLabel.AutoSize = true;
            this.lightsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lightsLabel.Location = new System.Drawing.Point(6, 155);
            this.lightsLabel.Name = "lightsLabel";
            this.lightsLabel.Size = new System.Drawing.Size(49, 19);
            this.lightsLabel.TabIndex = 2;
            this.lightsLabel.Text = "Lights: ";
            // 
            // particlesLabel
            // 
            this.particlesLabel.AutoSize = true;
            this.particlesLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.particlesLabel.Location = new System.Drawing.Point(6, 128);
            this.particlesLabel.Name = "particlesLabel";
            this.particlesLabel.Size = new System.Drawing.Size(60, 19);
            this.particlesLabel.TabIndex = 4;
            this.particlesLabel.Text = "Particles:";
            // 
            // comboBoxThreeOptionsParticles
            // 
            this.comboBoxThreeOptionsParticles.BackColor = System.Drawing.Color.White;
            this.comboBoxThreeOptionsParticles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeOptionsParticles.FormattingEnabled = true;
            this.comboBoxThreeOptionsParticles.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxThreeOptionsParticles.Location = new System.Drawing.Point(138, 128);
            this.comboBoxThreeOptionsParticles.Name = "comboBoxThreeOptionsParticles";
            this.comboBoxThreeOptionsParticles.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsParticles.TabIndex = 3;
            // 
            // animationQualityLabel
            // 
            this.animationQualityLabel.AutoSize = true;
            this.animationQualityLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.animationQualityLabel.Location = new System.Drawing.Point(6, 73);
            this.animationQualityLabel.Name = "animationQualityLabel";
            this.animationQualityLabel.Size = new System.Drawing.Size(117, 19);
            this.animationQualityLabel.TabIndex = 6;
            this.animationQualityLabel.Text = "Animation Quality:";
            // 
            // comboBoxThreeOptionsAnimQuality
            // 
            this.comboBoxThreeOptionsAnimQuality.BackColor = System.Drawing.Color.White;
            this.comboBoxThreeOptionsAnimQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeOptionsAnimQuality.FormattingEnabled = true;
            this.comboBoxThreeOptionsAnimQuality.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxThreeOptionsAnimQuality.Location = new System.Drawing.Point(138, 73);
            this.comboBoxThreeOptionsAnimQuality.Name = "comboBoxThreeOptionsAnimQuality";
            this.comboBoxThreeOptionsAnimQuality.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsAnimQuality.TabIndex = 5;
            // 
            // textureQualityLabel
            // 
            this.textureQualityLabel.AutoSize = true;
            this.textureQualityLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textureQualityLabel.Location = new System.Drawing.Point(6, 100);
            this.textureQualityLabel.Name = "textureQualityLabel";
            this.textureQualityLabel.Size = new System.Drawing.Size(98, 19);
            this.textureQualityLabel.TabIndex = 8;
            this.textureQualityLabel.Text = "Texture Quality:";
            // 
            // comboBoxThreeOptionsTexQuality
            // 
            this.comboBoxThreeOptionsTexQuality.BackColor = System.Drawing.Color.White;
            this.comboBoxThreeOptionsTexQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeOptionsTexQuality.FormattingEnabled = true;
            this.comboBoxThreeOptionsTexQuality.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxThreeOptionsTexQuality.Location = new System.Drawing.Point(138, 100);
            this.comboBoxThreeOptionsTexQuality.Name = "comboBoxThreeOptionsTexQuality";
            this.comboBoxThreeOptionsTexQuality.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsTexQuality.TabIndex = 7;
            // 
            // modelDetailLabel
            // 
            this.modelDetailLabel.AutoSize = true;
            this.modelDetailLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modelDetailLabel.Location = new System.Drawing.Point(285, 129);
            this.modelDetailLabel.Name = "modelDetailLabel";
            this.modelDetailLabel.Size = new System.Drawing.Size(87, 19);
            this.modelDetailLabel.TabIndex = 10;
            this.modelDetailLabel.Text = "Model Detail:";
            // 
            // comboBoxThreeOptionsModelDetail
            // 
            this.comboBoxThreeOptionsModelDetail.BackColor = System.Drawing.Color.White;
            this.comboBoxThreeOptionsModelDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeOptionsModelDetail.FormattingEnabled = true;
            this.comboBoxThreeOptionsModelDetail.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxThreeOptionsModelDetail.Location = new System.Drawing.Point(417, 129);
            this.comboBoxThreeOptionsModelDetail.Name = "comboBoxThreeOptionsModelDetail";
            this.comboBoxThreeOptionsModelDetail.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsModelDetail.TabIndex = 9;
            // 
            // spellDetailLabel
            // 
            this.spellDetailLabel.AutoSize = true;
            this.spellDetailLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.spellDetailLabel.Location = new System.Drawing.Point(6, 183);
            this.spellDetailLabel.Name = "spellDetailLabel";
            this.spellDetailLabel.Size = new System.Drawing.Size(77, 19);
            this.spellDetailLabel.TabIndex = 12;
            this.spellDetailLabel.Text = "Spell Detail:";
            // 
            // comboBoxThreeOptionsSpellFilter
            // 
            this.comboBoxThreeOptionsSpellFilter.BackColor = System.Drawing.Color.White;
            this.comboBoxThreeOptionsSpellFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreeOptionsSpellFilter.FormattingEnabled = true;
            this.comboBoxThreeOptionsSpellFilter.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboBoxThreeOptionsSpellFilter.Location = new System.Drawing.Point(138, 183);
            this.comboBoxThreeOptionsSpellFilter.Name = "comboBoxThreeOptionsSpellFilter";
            this.comboBoxThreeOptionsSpellFilter.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsSpellFilter.TabIndex = 11;
            // 
            // occlusionLabel
            // 
            this.occlusionLabel.AutoSize = true;
            this.occlusionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.occlusionLabel.Location = new System.Drawing.Point(284, 72);
            this.occlusionLabel.Name = "occlusionLabel";
            this.occlusionLabel.Size = new System.Drawing.Size(68, 19);
            this.occlusionLabel.TabIndex = 14;
            this.occlusionLabel.Text = "Occlusion:";
            // 
            // comboBoxBoolOptionsOcclusion
            // 
            this.comboBoxBoolOptionsOcclusion.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsOcclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsOcclusion.FormattingEnabled = true;
            this.comboBoxBoolOptionsOcclusion.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsOcclusion.Location = new System.Drawing.Point(417, 75);
            this.comboBoxBoolOptionsOcclusion.Name = "comboBoxBoolOptionsOcclusion";
            this.comboBoxBoolOptionsOcclusion.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsOcclusion.TabIndex = 13;
            // 
            // groupBoxVideoSettings
            // 
            this.groupBoxVideoSettings.Controls.Add(this.trackBarLabelGamma);
            this.groupBoxVideoSettings.Controls.Add(this.trackBarGamma);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxBitOptionsTexColorDepth);
            this.groupBoxVideoSettings.Controls.Add(this.texColorDepthLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxWindowMode);
            this.groupBoxVideoSettings.Controls.Add(this.windowModeLabel);
            this.groupBoxVideoSettings.Controls.Add(this.vsyncLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxBoolOptionsVSync);
            this.groupBoxVideoSettings.Controls.Add(this.screenResolutionLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxScreenResolution);
            this.groupBoxVideoSettings.Controls.Add(this.unitShadowsLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxBoolOptionsUnitShadows);
            this.groupBoxVideoSettings.Controls.Add(this.lightsLabel);
            this.groupBoxVideoSettings.Controls.Add(this.occlusionLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxThreeOptionsLights);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxBoolOptionsOcclusion);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxThreeOptionsParticles);
            this.groupBoxVideoSettings.Controls.Add(this.spellDetailLabel);
            this.groupBoxVideoSettings.Controls.Add(this.particlesLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxThreeOptionsSpellFilter);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxThreeOptionsAnimQuality);
            this.groupBoxVideoSettings.Controls.Add(this.modelDetailLabel);
            this.groupBoxVideoSettings.Controls.Add(this.animationQualityLabel);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxThreeOptionsModelDetail);
            this.groupBoxVideoSettings.Controls.Add(this.comboBoxThreeOptionsTexQuality);
            this.groupBoxVideoSettings.Controls.Add(this.textureQualityLabel);
            this.groupBoxVideoSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVideoSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxVideoSettings.Location = new System.Drawing.Point(12, 37);
            this.groupBoxVideoSettings.Name = "groupBoxVideoSettings";
            this.groupBoxVideoSettings.Size = new System.Drawing.Size(564, 213);
            this.groupBoxVideoSettings.TabIndex = 15;
            this.groupBoxVideoSettings.TabStop = false;
            this.groupBoxVideoSettings.Text = "Video Settings";
            // 
            // trackBarLabelGamma
            // 
            this.trackBarLabelGamma.AutoSize = true;
            this.trackBarLabelGamma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarLabelGamma.Location = new System.Drawing.Point(285, 156);
            this.trackBarLabelGamma.Name = "trackBarLabelGamma";
            this.trackBarLabelGamma.Size = new System.Drawing.Size(59, 19);
            this.trackBarLabelGamma.TabIndex = 26;
            this.trackBarLabelGamma.Text = "Gamma:";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.BackColor = System.Drawing.Color.Transparent;
            this.trackBarGamma.Location = new System.Drawing.Point(417, 156);
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(130, 23);
            this.trackBarGamma.TabIndex = 25;
            this.trackBarGamma.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarGamma_Scroll);
            // 
            // comboBoxBitOptionsTexColorDepth
            // 
            this.comboBoxBitOptionsTexColorDepth.BackColor = System.Drawing.Color.White;
            this.comboBoxBitOptionsTexColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitOptionsTexColorDepth.FormattingEnabled = true;
            this.comboBoxBitOptionsTexColorDepth.Items.AddRange(new object[] {
            "16bit",
            "32bit"});
            this.comboBoxBitOptionsTexColorDepth.Location = new System.Drawing.Point(417, 102);
            this.comboBoxBitOptionsTexColorDepth.Name = "comboBoxBitOptionsTexColorDepth";
            this.comboBoxBitOptionsTexColorDepth.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBitOptionsTexColorDepth.TabIndex = 23;
            // 
            // texColorDepthLabel
            // 
            this.texColorDepthLabel.AutoSize = true;
            this.texColorDepthLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.texColorDepthLabel.Location = new System.Drawing.Point(285, 102);
            this.texColorDepthLabel.Name = "texColorDepthLabel";
            this.texColorDepthLabel.Size = new System.Drawing.Size(129, 19);
            this.texColorDepthLabel.TabIndex = 24;
            this.texColorDepthLabel.Text = "Texture Color Depth:";
            // 
            // comboBoxWindowMode
            // 
            this.comboBoxWindowMode.BackColor = System.Drawing.Color.White;
            this.comboBoxWindowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWindowMode.FormattingEnabled = true;
            this.comboBoxWindowMode.Items.AddRange(new object[] {
            "Windowed",
            "Windowed Fullscreen",
            "Fullscreen"});
            this.comboBoxWindowMode.Location = new System.Drawing.Point(138, 46);
            this.comboBoxWindowMode.Name = "comboBoxWindowMode";
            this.comboBoxWindowMode.Size = new System.Drawing.Size(130, 21);
            this.comboBoxWindowMode.TabIndex = 21;
            // 
            // windowModeLabel
            // 
            this.windowModeLabel.AutoSize = true;
            this.windowModeLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.windowModeLabel.Location = new System.Drawing.Point(6, 46);
            this.windowModeLabel.Name = "windowModeLabel";
            this.windowModeLabel.Size = new System.Drawing.Size(99, 19);
            this.windowModeLabel.TabIndex = 22;
            this.windowModeLabel.Text = "Window Mode:";
            // 
            // vsyncLabel
            // 
            this.vsyncLabel.AutoSize = true;
            this.vsyncLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vsyncLabel.Location = new System.Drawing.Point(284, 48);
            this.vsyncLabel.Name = "vsyncLabel";
            this.vsyncLabel.Size = new System.Drawing.Size(46, 19);
            this.vsyncLabel.TabIndex = 20;
            this.vsyncLabel.Text = "VSync:";
            // 
            // comboBoxBoolOptionsVSync
            // 
            this.comboBoxBoolOptionsVSync.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsVSync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsVSync.FormattingEnabled = true;
            this.comboBoxBoolOptionsVSync.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsVSync.Location = new System.Drawing.Point(417, 48);
            this.comboBoxBoolOptionsVSync.Name = "comboBoxBoolOptionsVSync";
            this.comboBoxBoolOptionsVSync.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsVSync.TabIndex = 19;
            // 
            // screenResolutionLabel
            // 
            this.screenResolutionLabel.AutoSize = true;
            this.screenResolutionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.screenResolutionLabel.Location = new System.Drawing.Point(6, 19);
            this.screenResolutionLabel.Name = "screenResolutionLabel";
            this.screenResolutionLabel.Size = new System.Drawing.Size(115, 19);
            this.screenResolutionLabel.TabIndex = 18;
            this.screenResolutionLabel.Text = "Screen Resolution:";
            // 
            // comboBoxScreenResolution
            // 
            this.comboBoxScreenResolution.BackColor = System.Drawing.Color.White;
            this.comboBoxScreenResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScreenResolution.FormattingEnabled = true;
            this.comboBoxScreenResolution.Items.AddRange(new object[] {
            "640x480",
            "720x480",
            "800x600",
            "1024x768",
            "1152x864",
            "1176x664",
            "1280x720",
            "1360x768",
            "1366x768",
            "1440x900",
            "1600x900",
            "1680x1050",
            "1768x992",
            "1920x1080"});
            this.comboBoxScreenResolution.Location = new System.Drawing.Point(138, 19);
            this.comboBoxScreenResolution.Name = "comboBoxScreenResolution";
            this.comboBoxScreenResolution.Size = new System.Drawing.Size(130, 21);
            this.comboBoxScreenResolution.TabIndex = 17;
            // 
            // unitShadowsLabel
            // 
            this.unitShadowsLabel.AutoSize = true;
            this.unitShadowsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.unitShadowsLabel.Location = new System.Drawing.Point(284, 21);
            this.unitShadowsLabel.Name = "unitShadowsLabel";
            this.unitShadowsLabel.Size = new System.Drawing.Size(90, 19);
            this.unitShadowsLabel.TabIndex = 16;
            this.unitShadowsLabel.Text = "Unit Shadows:";
            // 
            // comboBoxBoolOptionsUnitShadows
            // 
            this.comboBoxBoolOptionsUnitShadows.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsUnitShadows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsUnitShadows.FormattingEnabled = true;
            this.comboBoxBoolOptionsUnitShadows.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsUnitShadows.Location = new System.Drawing.Point(417, 21);
            this.comboBoxBoolOptionsUnitShadows.Name = "comboBoxBoolOptionsUnitShadows";
            this.comboBoxBoolOptionsUnitShadows.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsUnitShadows.TabIndex = 15;
            // 
            // groupBoxSoundSettings
            // 
            this.groupBoxSoundSettings.Controls.Add(this.comboBoxBoolOptionsSubtitles);
            this.groupBoxSoundSettings.Controls.Add(this.subtitlesLabel);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarLabelMusic_Volume);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarMusic_Volume);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarLabelSfx_Volume);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarSFX_Volume);
            this.groupBoxSoundSettings.Location = new System.Drawing.Point(12, 256);
            this.groupBoxSoundSettings.Name = "groupBoxSoundSettings";
            this.groupBoxSoundSettings.Size = new System.Drawing.Size(564, 68);
            this.groupBoxSoundSettings.TabIndex = 27;
            this.groupBoxSoundSettings.TabStop = false;
            this.groupBoxSoundSettings.Text = "Sound Settings";
            // 
            // comboBoxBoolOptionsSubtitles
            // 
            this.comboBoxBoolOptionsSubtitles.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsSubtitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsSubtitles.FormattingEnabled = true;
            this.comboBoxBoolOptionsSubtitles.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsSubtitles.Location = new System.Drawing.Point(138, 41);
            this.comboBoxBoolOptionsSubtitles.Name = "comboBoxBoolOptionsSubtitles";
            this.comboBoxBoolOptionsSubtitles.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsSubtitles.TabIndex = 48;
            // 
            // subtitlesLabel
            // 
            this.subtitlesLabel.AutoSize = true;
            this.subtitlesLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.subtitlesLabel.Location = new System.Drawing.Point(8, 41);
            this.subtitlesLabel.Name = "subtitlesLabel";
            this.subtitlesLabel.Size = new System.Drawing.Size(64, 19);
            this.subtitlesLabel.TabIndex = 47;
            this.subtitlesLabel.Text = "Subtitles: ";
            // 
            // trackBarLabelMusic_Volume
            // 
            this.trackBarLabelMusic_Volume.AutoSize = true;
            this.trackBarLabelMusic_Volume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarLabelMusic_Volume.Location = new System.Drawing.Point(287, 16);
            this.trackBarLabelMusic_Volume.Name = "trackBarLabelMusic_Volume";
            this.trackBarLabelMusic_Volume.Size = new System.Drawing.Size(93, 19);
            this.trackBarLabelMusic_Volume.TabIndex = 30;
            this.trackBarLabelMusic_Volume.Text = "Music Volume:";
            // 
            // trackBarMusic_Volume
            // 
            this.trackBarMusic_Volume.BackColor = System.Drawing.Color.Transparent;
            this.trackBarMusic_Volume.Location = new System.Drawing.Point(419, 12);
            this.trackBarMusic_Volume.Name = "trackBarMusic_Volume";
            this.trackBarMusic_Volume.Size = new System.Drawing.Size(130, 23);
            this.trackBarMusic_Volume.TabIndex = 29;
            this.trackBarMusic_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarMusicVolume_Scroll);
            // 
            // trackBarLabelSfx_Volume
            // 
            this.trackBarLabelSfx_Volume.AutoSize = true;
            this.trackBarLabelSfx_Volume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarLabelSfx_Volume.Location = new System.Drawing.Point(8, 16);
            this.trackBarLabelSfx_Volume.Name = "trackBarLabelSfx_Volume";
            this.trackBarLabelSfx_Volume.Size = new System.Drawing.Size(82, 19);
            this.trackBarLabelSfx_Volume.TabIndex = 28;
            this.trackBarLabelSfx_Volume.Text = "SFX Volume:";
            // 
            // trackBarSFX_Volume
            // 
            this.trackBarSFX_Volume.BackColor = System.Drawing.Color.Transparent;
            this.trackBarSFX_Volume.Location = new System.Drawing.Point(140, 12);
            this.trackBarSFX_Volume.Name = "trackBarSFX_Volume";
            this.trackBarSFX_Volume.Size = new System.Drawing.Size(130, 23);
            this.trackBarSFX_Volume.TabIndex = 27;
            this.trackBarSFX_Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarSfxVolume_Scroll);
            // 
            // groupBoxGameplaySettings
            // 
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptions_autosaveReplay);
            this.groupBoxGameplaySettings.Controls.Add(this.autoSaveReplayLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptionsCustomKeys);
            this.groupBoxGameplaySettings.Controls.Add(this.customKeysLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptionsDisplayFps);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptionsDisplayPing);
            this.groupBoxGameplaySettings.Controls.Add(this.displayFpsLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.displayPingLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarLabelMouse_Scroll);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarMouse_Scroll);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarLabelKey_Scroll);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarKey_Scroll);
            this.groupBoxGameplaySettings.Location = new System.Drawing.Point(12, 330);
            this.groupBoxGameplaySettings.Name = "groupBoxGameplaySettings";
            this.groupBoxGameplaySettings.Size = new System.Drawing.Size(564, 101);
            this.groupBoxGameplaySettings.TabIndex = 31;
            this.groupBoxGameplaySettings.TabStop = false;
            this.groupBoxGameplaySettings.Text = "Gameplay Settings";
            // 
            // comboBoxBoolOptions_autosaveReplay
            // 
            this.comboBoxBoolOptions_autosaveReplay.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptions_autosaveReplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptions_autosaveReplay.FormattingEnabled = true;
            this.comboBoxBoolOptions_autosaveReplay.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptions_autosaveReplay.Location = new System.Drawing.Point(419, 69);
            this.comboBoxBoolOptions_autosaveReplay.Name = "comboBoxBoolOptions_autosaveReplay";
            this.comboBoxBoolOptions_autosaveReplay.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptions_autosaveReplay.TabIndex = 44;
            // 
            // autoSaveReplayLabel
            // 
            this.autoSaveReplayLabel.AutoSize = true;
            this.autoSaveReplayLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.autoSaveReplayLabel.Location = new System.Drawing.Point(287, 71);
            this.autoSaveReplayLabel.Name = "autoSaveReplayLabel";
            this.autoSaveReplayLabel.Size = new System.Drawing.Size(118, 19);
            this.autoSaveReplayLabel.TabIndex = 43;
            this.autoSaveReplayLabel.Text = "Auto Save Replay: ";
            // 
            // comboBoxBoolOptionsCustomKeys
            // 
            this.comboBoxBoolOptionsCustomKeys.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsCustomKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsCustomKeys.FormattingEnabled = true;
            this.comboBoxBoolOptionsCustomKeys.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsCustomKeys.Location = new System.Drawing.Point(140, 71);
            this.comboBoxBoolOptionsCustomKeys.Name = "comboBoxBoolOptionsCustomKeys";
            this.comboBoxBoolOptionsCustomKeys.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsCustomKeys.TabIndex = 42;
            // 
            // customKeysLabel
            // 
            this.customKeysLabel.AutoSize = true;
            this.customKeysLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.customKeysLabel.Location = new System.Drawing.Point(8, 71);
            this.customKeysLabel.Name = "customKeysLabel";
            this.customKeysLabel.Size = new System.Drawing.Size(90, 19);
            this.customKeysLabel.TabIndex = 41;
            this.customKeysLabel.Text = "Custom Keys: ";
            // 
            // comboBoxBoolOptionsDisplayFps
            // 
            this.comboBoxBoolOptionsDisplayFps.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsDisplayFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsDisplayFps.FormattingEnabled = true;
            this.comboBoxBoolOptionsDisplayFps.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsDisplayFps.Location = new System.Drawing.Point(419, 42);
            this.comboBoxBoolOptionsDisplayFps.Name = "comboBoxBoolOptionsDisplayFps";
            this.comboBoxBoolOptionsDisplayFps.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsDisplayFps.TabIndex = 40;
            // 
            // comboBoxBoolOptionsDisplayPing
            // 
            this.comboBoxBoolOptionsDisplayPing.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsDisplayPing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsDisplayPing.FormattingEnabled = true;
            this.comboBoxBoolOptionsDisplayPing.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsDisplayPing.Location = new System.Drawing.Point(140, 44);
            this.comboBoxBoolOptionsDisplayPing.Name = "comboBoxBoolOptionsDisplayPing";
            this.comboBoxBoolOptionsDisplayPing.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsDisplayPing.TabIndex = 39;
            // 
            // displayFpsLabel
            // 
            this.displayFpsLabel.AutoSize = true;
            this.displayFpsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.displayFpsLabel.Location = new System.Drawing.Point(287, 44);
            this.displayFpsLabel.Name = "displayFpsLabel";
            this.displayFpsLabel.Size = new System.Drawing.Size(83, 19);
            this.displayFpsLabel.TabIndex = 38;
            this.displayFpsLabel.Text = "Display FPS: ";
            // 
            // displayPingLabel
            // 
            this.displayPingLabel.AutoSize = true;
            this.displayPingLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.displayPingLabel.Location = new System.Drawing.Point(8, 44);
            this.displayPingLabel.Name = "displayPingLabel";
            this.displayPingLabel.Size = new System.Drawing.Size(87, 19);
            this.displayPingLabel.TabIndex = 36;
            this.displayPingLabel.Text = "Display Ping: ";
            // 
            // trackBarLabelMouse_Scroll
            // 
            this.trackBarLabelMouse_Scroll.AutoSize = true;
            this.trackBarLabelMouse_Scroll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarLabelMouse_Scroll.Location = new System.Drawing.Point(287, 23);
            this.trackBarLabelMouse_Scroll.Name = "trackBarLabelMouse_Scroll";
            this.trackBarLabelMouse_Scroll.Size = new System.Drawing.Size(87, 19);
            this.trackBarLabelMouse_Scroll.TabIndex = 34;
            this.trackBarLabelMouse_Scroll.Text = "Mouse Scroll:";
            // 
            // trackBarMouse_Scroll
            // 
            this.trackBarMouse_Scroll.BackColor = System.Drawing.Color.Transparent;
            this.trackBarMouse_Scroll.Location = new System.Drawing.Point(419, 19);
            this.trackBarMouse_Scroll.Name = "trackBarMouse_Scroll";
            this.trackBarMouse_Scroll.Size = new System.Drawing.Size(130, 23);
            this.trackBarMouse_Scroll.TabIndex = 33;
            this.trackBarMouse_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarMouseScroll_Scroll);
            // 
            // trackBarLabelKey_Scroll
            // 
            this.trackBarLabelKey_Scroll.AutoSize = true;
            this.trackBarLabelKey_Scroll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarLabelKey_Scroll.Location = new System.Drawing.Point(10, 23);
            this.trackBarLabelKey_Scroll.Name = "trackBarLabelKey_Scroll";
            this.trackBarLabelKey_Scroll.Size = new System.Drawing.Size(68, 19);
            this.trackBarLabelKey_Scroll.TabIndex = 32;
            this.trackBarLabelKey_Scroll.Text = "Key Scroll:";
            // 
            // trackBarKey_Scroll
            // 
            this.trackBarKey_Scroll.BackColor = System.Drawing.Color.Transparent;
            this.trackBarKey_Scroll.Location = new System.Drawing.Point(140, 19);
            this.trackBarKey_Scroll.Name = "trackBarKey_Scroll";
            this.trackBarKey_Scroll.Size = new System.Drawing.Size(130, 23);
            this.trackBarKey_Scroll.TabIndex = 31;
            this.trackBarKey_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarKeyScroll_Scroll);
            // 
            // textBoxCampaignProfile
            // 
            // 
            // 
            // 
            this.textBoxCampaignProfile.CustomButton.Image = null;
            this.textBoxCampaignProfile.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.textBoxCampaignProfile.CustomButton.Name = "";
            this.textBoxCampaignProfile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxCampaignProfile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxCampaignProfile.CustomButton.TabIndex = 1;
            this.textBoxCampaignProfile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxCampaignProfile.CustomButton.UseSelectable = true;
            this.textBoxCampaignProfile.CustomButton.Visible = false;
            this.textBoxCampaignProfile.Lines = new string[0];
            this.textBoxCampaignProfile.Location = new System.Drawing.Point(152, 440);
            this.textBoxCampaignProfile.MaxLength = 32767;
            this.textBoxCampaignProfile.Name = "textBoxCampaignProfile";
            this.textBoxCampaignProfile.PasswordChar = '\0';
            this.textBoxCampaignProfile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCampaignProfile.SelectedText = "";
            this.textBoxCampaignProfile.SelectionLength = 0;
            this.textBoxCampaignProfile.SelectionStart = 0;
            this.textBoxCampaignProfile.ShortcutsEnabled = true;
            this.textBoxCampaignProfile.Size = new System.Drawing.Size(130, 23);
            this.textBoxCampaignProfile.TabIndex = 32;
            this.textBoxCampaignProfile.UseSelectable = true;
            this.textBoxCampaignProfile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxCampaignProfile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // campaignProfileLabel
            // 
            this.campaignProfileLabel.AutoSize = true;
            this.campaignProfileLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.campaignProfileLabel.Location = new System.Drawing.Point(20, 440);
            this.campaignProfileLabel.Name = "campaignProfileLabel";
            this.campaignProfileLabel.Size = new System.Drawing.Size(123, 19);
            this.campaignProfileLabel.TabIndex = 45;
            this.campaignProfileLabel.Text = "Campaign profile:  ";
            // 
            // userLocalLabel
            // 
            this.userLocalLabel.AutoSize = true;
            this.userLocalLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userLocalLabel.Location = new System.Drawing.Point(299, 440);
            this.userLocalLabel.Name = "userLocalLabel";
            this.userLocalLabel.Size = new System.Drawing.Size(87, 19);
            this.userLocalLabel.TabIndex = 47;
            this.userLocalLabel.Text = "Profile name:";
            // 
            // textBoxUserLocal
            // 
            // 
            // 
            // 
            this.textBoxUserLocal.CustomButton.Image = null;
            this.textBoxUserLocal.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.textBoxUserLocal.CustomButton.Name = "";
            this.textBoxUserLocal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUserLocal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUserLocal.CustomButton.TabIndex = 1;
            this.textBoxUserLocal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUserLocal.CustomButton.UseSelectable = true;
            this.textBoxUserLocal.CustomButton.Visible = false;
            this.textBoxUserLocal.Lines = new string[0];
            this.textBoxUserLocal.Location = new System.Drawing.Point(431, 440);
            this.textBoxUserLocal.MaxLength = 32767;
            this.textBoxUserLocal.Name = "textBoxUserLocal";
            this.textBoxUserLocal.PasswordChar = '\0';
            this.textBoxUserLocal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUserLocal.SelectedText = "";
            this.textBoxUserLocal.SelectionLength = 0;
            this.textBoxUserLocal.SelectionStart = 0;
            this.textBoxUserLocal.ShortcutsEnabled = true;
            this.textBoxUserLocal.Size = new System.Drawing.Size(130, 23);
            this.textBoxUserLocal.TabIndex = 46;
            this.textBoxUserLocal.UseSelectable = true;
            this.textBoxUserLocal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUserLocal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // W3Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(590, 475);
            this.Controls.Add(this.userLocalLabel);
            this.Controls.Add(this.textBoxUserLocal);
            this.Controls.Add(this.campaignProfileLabel);
            this.Controls.Add(this.textBoxCampaignProfile);
            this.Controls.Add(this.groupBoxGameplaySettings);
            this.Controls.Add(this.groupBoxSoundSettings);
            this.Controls.Add(this.groupBoxVideoSettings);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "W3Settings";
            this.Text = "W3Settings";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxVideoSettings.ResumeLayout(false);
            this.groupBoxVideoSettings.PerformLayout();
            this.groupBoxSoundSettings.ResumeLayout(false);
            this.groupBoxSoundSettings.PerformLayout();
            this.groupBoxGameplaySettings.ResumeLayout(false);
            this.groupBoxGameplaySettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToTheMainWindowToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsLights;
        private MetroFramework.Controls.MetroLabel lightsLabel;
        private MetroFramework.Controls.MetroLabel particlesLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsParticles;
        private MetroFramework.Controls.MetroLabel animationQualityLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsAnimQuality;
        private MetroFramework.Controls.MetroLabel textureQualityLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsTexQuality;
        private MetroFramework.Controls.MetroLabel modelDetailLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsModelDetail;
        private MetroFramework.Controls.MetroLabel spellDetailLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsSpellFilter;
        private MetroFramework.Controls.MetroLabel occlusionLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsOcclusion;
        private System.Windows.Forms.GroupBox groupBoxVideoSettings;
        private MetroFramework.Controls.MetroLabel unitShadowsLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsUnitShadows;
        private MetroFramework.Controls.MetroLabel screenResolutionLabel;
        private System.Windows.Forms.ComboBox comboBoxScreenResolution;
        private MetroFramework.Controls.MetroLabel vsyncLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsVSync;
        private System.Windows.Forms.ComboBox comboBoxWindowMode;
        private MetroFramework.Controls.MetroLabel windowModeLabel;
        private System.Windows.Forms.ComboBox comboBoxBitOptionsTexColorDepth;
        private MetroFramework.Controls.MetroLabel texColorDepthLabel;
        private MetroFramework.Controls.MetroLabel trackBarLabelGamma;
        private MetroFramework.Controls.MetroTrackBar trackBarGamma;
        private System.Windows.Forms.GroupBox groupBoxSoundSettings;
        private MetroFramework.Controls.MetroLabel trackBarLabelMusic_Volume;
        private MetroFramework.Controls.MetroTrackBar trackBarMusic_Volume;
        private MetroFramework.Controls.MetroLabel trackBarLabelSfx_Volume;
        private MetroFramework.Controls.MetroTrackBar trackBarSFX_Volume;
        private System.Windows.Forms.GroupBox groupBoxGameplaySettings;
        private MetroFramework.Controls.MetroLabel trackBarLabelMouse_Scroll;
        private MetroFramework.Controls.MetroTrackBar trackBarMouse_Scroll;
        private MetroFramework.Controls.MetroLabel trackBarLabelKey_Scroll;
        private MetroFramework.Controls.MetroTrackBar trackBarKey_Scroll;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsDisplayFps;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsDisplayPing;
        private MetroFramework.Controls.MetroLabel displayFpsLabel;
        private MetroFramework.Controls.MetroLabel displayPingLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptions_autosaveReplay;
        private MetroFramework.Controls.MetroLabel autoSaveReplayLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsCustomKeys;
        private MetroFramework.Controls.MetroLabel customKeysLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsSubtitles;
        private MetroFramework.Controls.MetroLabel subtitlesLabel;
        private MetroFramework.Controls.MetroTextBox textBoxCampaignProfile;
        private MetroFramework.Controls.MetroLabel campaignProfileLabel;
        private MetroFramework.Controls.MetroLabel userLocalLabel;
        private MetroFramework.Controls.MetroTextBox textBoxUserLocal;
    }
}