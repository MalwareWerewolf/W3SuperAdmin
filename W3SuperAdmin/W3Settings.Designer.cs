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
            this.lightsLabel = new System.Windows.Forms.Label();
            this.particlesLabel = new System.Windows.Forms.Label();
            this.comboBoxThreeOptionsParticles = new System.Windows.Forms.ComboBox();
            this.animationQualityLabel = new System.Windows.Forms.Label();
            this.comboBoxThreeOptionsAnimQuality = new System.Windows.Forms.ComboBox();
            this.textureQualityLabel = new System.Windows.Forms.Label();
            this.comboBoxThreeOptionsTexQuality = new System.Windows.Forms.ComboBox();
            this.modelDetailLabel = new System.Windows.Forms.Label();
            this.comboBoxThreeOptionsModelDetail = new System.Windows.Forms.ComboBox();
            this.spellDetailLabel = new System.Windows.Forms.Label();
            this.comboBoxThreeOptionsSpellFilter = new System.Windows.Forms.ComboBox();
            this.occlusionLabel = new System.Windows.Forms.Label();
            this.comboBoxBoolOptionsOcclusion = new System.Windows.Forms.ComboBox();
            this.groupBoxVideoSettings = new System.Windows.Forms.GroupBox();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.trackBarLabelGamma = new System.Windows.Forms.Label();
            this.comboBoxBitOptionsTexColorDepth = new System.Windows.Forms.ComboBox();
            this.texColorDepthLabel = new System.Windows.Forms.Label();
            this.comboBoxWindowMode = new System.Windows.Forms.ComboBox();
            this.windowModeLabel = new System.Windows.Forms.Label();
            this.vsyncLabel = new System.Windows.Forms.Label();
            this.comboBoxBoolOptionsVSync = new System.Windows.Forms.ComboBox();
            this.screenResolutionLabel = new System.Windows.Forms.Label();
            this.comboBoxScreenResolution = new System.Windows.Forms.ComboBox();
            this.unitShadowsLabel = new System.Windows.Forms.Label();
            this.comboBoxBoolOptionsUnitShadows = new System.Windows.Forms.ComboBox();
            this.groupBoxSoundSettings = new System.Windows.Forms.GroupBox();
            this.trackBarSFX_Volume = new System.Windows.Forms.TrackBar();
            this.trackBarMusic_Volume = new System.Windows.Forms.TrackBar();
            this.comboBoxBoolOptionsSubtitles = new System.Windows.Forms.ComboBox();
            this.subtitlesLabel = new System.Windows.Forms.Label();
            this.trackBarLabelMusic_Volume = new System.Windows.Forms.Label();
            this.trackBarLabelSfx_Volume = new System.Windows.Forms.Label();
            this.groupBoxGameplaySettings = new System.Windows.Forms.GroupBox();
            this.trackBarMouse_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarKey_Scroll = new System.Windows.Forms.TrackBar();
            this.comboBoxBoolOptions_autosaveReplay = new System.Windows.Forms.ComboBox();
            this.autoSaveReplayLabel = new System.Windows.Forms.Label();
            this.comboBoxBoolOptionsCustomKeys = new System.Windows.Forms.ComboBox();
            this.customKeysLabel = new System.Windows.Forms.Label();
            this.comboBoxBoolOptionsDisplayFps = new System.Windows.Forms.ComboBox();
            this.comboBoxBoolOptionsDisplayPing = new System.Windows.Forms.ComboBox();
            this.displayFpsLabel = new System.Windows.Forms.Label();
            this.displayPingLabel = new System.Windows.Forms.Label();
            this.trackBarLabelMouse_Scroll = new System.Windows.Forms.Label();
            this.trackBarLabelKey_Scroll = new System.Windows.Forms.Label();
            this.textBoxCampaignProfile = new System.Windows.Forms.TextBox();
            this.campaignProfileLabel = new System.Windows.Forms.Label();
            this.userLocalLabel = new System.Windows.Forms.Label();
            this.textBoxUserLocal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxVideoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.groupBoxSoundSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSFX_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic_Volume)).BeginInit();
            this.groupBoxGameplaySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMouse_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKey_Scroll)).BeginInit();
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
            this.lightsLabel.BackColor = System.Drawing.Color.White;
            this.lightsLabel.Location = new System.Drawing.Point(6, 155);
            this.lightsLabel.Name = "lightsLabel";
            this.lightsLabel.Size = new System.Drawing.Size(41, 13);
            this.lightsLabel.TabIndex = 2;
            this.lightsLabel.Text = "Lights: ";
            // 
            // particlesLabel
            // 
            this.particlesLabel.AutoSize = true;
            this.particlesLabel.BackColor = System.Drawing.Color.White;
            this.particlesLabel.Location = new System.Drawing.Point(6, 128);
            this.particlesLabel.Name = "particlesLabel";
            this.particlesLabel.Size = new System.Drawing.Size(50, 13);
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
            this.animationQualityLabel.BackColor = System.Drawing.Color.White;
            this.animationQualityLabel.Location = new System.Drawing.Point(6, 73);
            this.animationQualityLabel.Name = "animationQualityLabel";
            this.animationQualityLabel.Size = new System.Drawing.Size(91, 13);
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
            this.textureQualityLabel.BackColor = System.Drawing.Color.White;
            this.textureQualityLabel.Location = new System.Drawing.Point(6, 100);
            this.textureQualityLabel.Name = "textureQualityLabel";
            this.textureQualityLabel.Size = new System.Drawing.Size(81, 13);
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
            this.modelDetailLabel.BackColor = System.Drawing.Color.White;
            this.modelDetailLabel.Location = new System.Drawing.Point(285, 129);
            this.modelDetailLabel.Name = "modelDetailLabel";
            this.modelDetailLabel.Size = new System.Drawing.Size(69, 13);
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
            this.comboBoxThreeOptionsModelDetail.Location = new System.Drawing.Point(396, 129);
            this.comboBoxThreeOptionsModelDetail.Name = "comboBoxThreeOptionsModelDetail";
            this.comboBoxThreeOptionsModelDetail.Size = new System.Drawing.Size(130, 21);
            this.comboBoxThreeOptionsModelDetail.TabIndex = 9;
            // 
            // spellDetailLabel
            // 
            this.spellDetailLabel.AutoSize = true;
            this.spellDetailLabel.BackColor = System.Drawing.Color.White;
            this.spellDetailLabel.Location = new System.Drawing.Point(6, 183);
            this.spellDetailLabel.Name = "spellDetailLabel";
            this.spellDetailLabel.Size = new System.Drawing.Size(63, 13);
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
            this.occlusionLabel.BackColor = System.Drawing.Color.White;
            this.occlusionLabel.Location = new System.Drawing.Point(284, 72);
            this.occlusionLabel.Name = "occlusionLabel";
            this.occlusionLabel.Size = new System.Drawing.Size(57, 13);
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
            this.comboBoxBoolOptionsOcclusion.Location = new System.Drawing.Point(396, 75);
            this.comboBoxBoolOptionsOcclusion.Name = "comboBoxBoolOptionsOcclusion";
            this.comboBoxBoolOptionsOcclusion.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsOcclusion.TabIndex = 13;
            // 
            // groupBoxVideoSettings
            // 
            this.groupBoxVideoSettings.Controls.Add(this.trackBarGamma);
            this.groupBoxVideoSettings.Controls.Add(this.trackBarLabelGamma);
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
            // trackBarGamma
            // 
            this.trackBarGamma.Location = new System.Drawing.Point(396, 153);
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(130, 45);
            this.trackBarGamma.TabIndex = 27;
            this.trackBarGamma.Scroll += new System.EventHandler(this.trackBarGamma_Scroll);
            // 
            // trackBarLabelGamma
            // 
            this.trackBarLabelGamma.AutoSize = true;
            this.trackBarLabelGamma.BackColor = System.Drawing.Color.White;
            this.trackBarLabelGamma.Location = new System.Drawing.Point(285, 156);
            this.trackBarLabelGamma.Name = "trackBarLabelGamma";
            this.trackBarLabelGamma.Size = new System.Drawing.Size(46, 13);
            this.trackBarLabelGamma.TabIndex = 26;
            this.trackBarLabelGamma.Text = "Gamma:";
            // 
            // comboBoxBitOptionsTexColorDepth
            // 
            this.comboBoxBitOptionsTexColorDepth.BackColor = System.Drawing.Color.White;
            this.comboBoxBitOptionsTexColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitOptionsTexColorDepth.FormattingEnabled = true;
            this.comboBoxBitOptionsTexColorDepth.Items.AddRange(new object[] {
            "16bit",
            "32bit"});
            this.comboBoxBitOptionsTexColorDepth.Location = new System.Drawing.Point(396, 102);
            this.comboBoxBitOptionsTexColorDepth.Name = "comboBoxBitOptionsTexColorDepth";
            this.comboBoxBitOptionsTexColorDepth.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBitOptionsTexColorDepth.TabIndex = 23;
            // 
            // texColorDepthLabel
            // 
            this.texColorDepthLabel.AutoSize = true;
            this.texColorDepthLabel.BackColor = System.Drawing.Color.White;
            this.texColorDepthLabel.Location = new System.Drawing.Point(285, 102);
            this.texColorDepthLabel.Name = "texColorDepthLabel";
            this.texColorDepthLabel.Size = new System.Drawing.Size(105, 13);
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
            this.windowModeLabel.BackColor = System.Drawing.Color.White;
            this.windowModeLabel.ForeColor = System.Drawing.Color.Black;
            this.windowModeLabel.Location = new System.Drawing.Point(6, 46);
            this.windowModeLabel.Name = "windowModeLabel";
            this.windowModeLabel.Size = new System.Drawing.Size(79, 13);
            this.windowModeLabel.TabIndex = 22;
            this.windowModeLabel.Text = "Window Mode:";
            // 
            // vsyncLabel
            // 
            this.vsyncLabel.AutoSize = true;
            this.vsyncLabel.BackColor = System.Drawing.Color.White;
            this.vsyncLabel.Location = new System.Drawing.Point(284, 48);
            this.vsyncLabel.Name = "vsyncLabel";
            this.vsyncLabel.Size = new System.Drawing.Size(41, 13);
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
            this.comboBoxBoolOptionsVSync.Location = new System.Drawing.Point(396, 48);
            this.comboBoxBoolOptionsVSync.Name = "comboBoxBoolOptionsVSync";
            this.comboBoxBoolOptionsVSync.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsVSync.TabIndex = 19;
            // 
            // screenResolutionLabel
            // 
            this.screenResolutionLabel.AutoSize = true;
            this.screenResolutionLabel.BackColor = System.Drawing.Color.White;
            this.screenResolutionLabel.ForeColor = System.Drawing.Color.Black;
            this.screenResolutionLabel.Location = new System.Drawing.Point(6, 19);
            this.screenResolutionLabel.Name = "screenResolutionLabel";
            this.screenResolutionLabel.Size = new System.Drawing.Size(97, 13);
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
            this.unitShadowsLabel.BackColor = System.Drawing.Color.White;
            this.unitShadowsLabel.Location = new System.Drawing.Point(284, 21);
            this.unitShadowsLabel.Name = "unitShadowsLabel";
            this.unitShadowsLabel.Size = new System.Drawing.Size(76, 13);
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
            this.comboBoxBoolOptionsUnitShadows.Location = new System.Drawing.Point(396, 21);
            this.comboBoxBoolOptionsUnitShadows.Name = "comboBoxBoolOptionsUnitShadows";
            this.comboBoxBoolOptionsUnitShadows.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsUnitShadows.TabIndex = 15;
            // 
            // groupBoxSoundSettings
            // 
            this.groupBoxSoundSettings.Controls.Add(this.trackBarSFX_Volume);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarMusic_Volume);
            this.groupBoxSoundSettings.Controls.Add(this.comboBoxBoolOptionsSubtitles);
            this.groupBoxSoundSettings.Controls.Add(this.subtitlesLabel);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarLabelMusic_Volume);
            this.groupBoxSoundSettings.Controls.Add(this.trackBarLabelSfx_Volume);
            this.groupBoxSoundSettings.Location = new System.Drawing.Point(12, 256);
            this.groupBoxSoundSettings.Name = "groupBoxSoundSettings";
            this.groupBoxSoundSettings.Size = new System.Drawing.Size(564, 93);
            this.groupBoxSoundSettings.TabIndex = 27;
            this.groupBoxSoundSettings.TabStop = false;
            this.groupBoxSoundSettings.Text = "Sound Settings";
            // 
            // trackBarSFX_Volume
            // 
            this.trackBarSFX_Volume.Location = new System.Drawing.Point(138, 9);
            this.trackBarSFX_Volume.Name = "trackBarSFX_Volume";
            this.trackBarSFX_Volume.Size = new System.Drawing.Size(130, 45);
            this.trackBarSFX_Volume.TabIndex = 50;
            this.trackBarSFX_Volume.Scroll += new System.EventHandler(this.trackBarSFX_Volume_Scroll);
            // 
            // trackBarMusic_Volume
            // 
            this.trackBarMusic_Volume.Location = new System.Drawing.Point(396, 9);
            this.trackBarMusic_Volume.Name = "trackBarMusic_Volume";
            this.trackBarMusic_Volume.Size = new System.Drawing.Size(130, 45);
            this.trackBarMusic_Volume.TabIndex = 49;
            this.trackBarMusic_Volume.Scroll += new System.EventHandler(this.trackBarMusic_Volume_Scroll);
            // 
            // comboBoxBoolOptionsSubtitles
            // 
            this.comboBoxBoolOptionsSubtitles.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptionsSubtitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptionsSubtitles.FormattingEnabled = true;
            this.comboBoxBoolOptionsSubtitles.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptionsSubtitles.Location = new System.Drawing.Point(138, 60);
            this.comboBoxBoolOptionsSubtitles.Name = "comboBoxBoolOptionsSubtitles";
            this.comboBoxBoolOptionsSubtitles.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsSubtitles.TabIndex = 48;
            // 
            // subtitlesLabel
            // 
            this.subtitlesLabel.AutoSize = true;
            this.subtitlesLabel.BackColor = System.Drawing.Color.White;
            this.subtitlesLabel.Location = new System.Drawing.Point(8, 60);
            this.subtitlesLabel.Name = "subtitlesLabel";
            this.subtitlesLabel.Size = new System.Drawing.Size(53, 13);
            this.subtitlesLabel.TabIndex = 47;
            this.subtitlesLabel.Text = "Subtitles: ";
            // 
            // trackBarLabelMusic_Volume
            // 
            this.trackBarLabelMusic_Volume.AutoSize = true;
            this.trackBarLabelMusic_Volume.BackColor = System.Drawing.Color.White;
            this.trackBarLabelMusic_Volume.Location = new System.Drawing.Point(287, 16);
            this.trackBarLabelMusic_Volume.Name = "trackBarLabelMusic_Volume";
            this.trackBarLabelMusic_Volume.Size = new System.Drawing.Size(76, 13);
            this.trackBarLabelMusic_Volume.TabIndex = 30;
            this.trackBarLabelMusic_Volume.Text = "Music Volume:";
            // 
            // trackBarLabelSfx_Volume
            // 
            this.trackBarLabelSfx_Volume.AutoSize = true;
            this.trackBarLabelSfx_Volume.BackColor = System.Drawing.Color.White;
            this.trackBarLabelSfx_Volume.Location = new System.Drawing.Point(8, 16);
            this.trackBarLabelSfx_Volume.Name = "trackBarLabelSfx_Volume";
            this.trackBarLabelSfx_Volume.Size = new System.Drawing.Size(68, 13);
            this.trackBarLabelSfx_Volume.TabIndex = 28;
            this.trackBarLabelSfx_Volume.Text = "SFX Volume:";
            // 
            // groupBoxGameplaySettings
            // 
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarMouse_Scroll);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarKey_Scroll);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptions_autosaveReplay);
            this.groupBoxGameplaySettings.Controls.Add(this.autoSaveReplayLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptionsCustomKeys);
            this.groupBoxGameplaySettings.Controls.Add(this.customKeysLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptionsDisplayFps);
            this.groupBoxGameplaySettings.Controls.Add(this.comboBoxBoolOptionsDisplayPing);
            this.groupBoxGameplaySettings.Controls.Add(this.displayFpsLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.displayPingLabel);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarLabelMouse_Scroll);
            this.groupBoxGameplaySettings.Controls.Add(this.trackBarLabelKey_Scroll);
            this.groupBoxGameplaySettings.Location = new System.Drawing.Point(12, 355);
            this.groupBoxGameplaySettings.Name = "groupBoxGameplaySettings";
            this.groupBoxGameplaySettings.Size = new System.Drawing.Size(564, 117);
            this.groupBoxGameplaySettings.TabIndex = 31;
            this.groupBoxGameplaySettings.TabStop = false;
            this.groupBoxGameplaySettings.Text = "Gameplay Settings";
            // 
            // trackBarMouse_Scroll
            // 
            this.trackBarMouse_Scroll.Location = new System.Drawing.Point(396, 12);
            this.trackBarMouse_Scroll.Name = "trackBarMouse_Scroll";
            this.trackBarMouse_Scroll.Size = new System.Drawing.Size(132, 45);
            this.trackBarMouse_Scroll.TabIndex = 46;
            this.trackBarMouse_Scroll.Scroll += new System.EventHandler(this.trackBarMouse_Scroll_Scroll);
            // 
            // trackBarKey_Scroll
            // 
            this.trackBarKey_Scroll.Location = new System.Drawing.Point(138, 12);
            this.trackBarKey_Scroll.Name = "trackBarKey_Scroll";
            this.trackBarKey_Scroll.Size = new System.Drawing.Size(132, 45);
            this.trackBarKey_Scroll.TabIndex = 45;
            this.trackBarKey_Scroll.Scroll += new System.EventHandler(this.trackBarKey_Scroll_Scroll);
            // 
            // comboBoxBoolOptions_autosaveReplay
            // 
            this.comboBoxBoolOptions_autosaveReplay.BackColor = System.Drawing.Color.White;
            this.comboBoxBoolOptions_autosaveReplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoolOptions_autosaveReplay.FormattingEnabled = true;
            this.comboBoxBoolOptions_autosaveReplay.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBoxBoolOptions_autosaveReplay.Location = new System.Drawing.Point(398, 90);
            this.comboBoxBoolOptions_autosaveReplay.Name = "comboBoxBoolOptions_autosaveReplay";
            this.comboBoxBoolOptions_autosaveReplay.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptions_autosaveReplay.TabIndex = 44;
            // 
            // autoSaveReplayLabel
            // 
            this.autoSaveReplayLabel.AutoSize = true;
            this.autoSaveReplayLabel.BackColor = System.Drawing.Color.White;
            this.autoSaveReplayLabel.Location = new System.Drawing.Point(285, 90);
            this.autoSaveReplayLabel.Name = "autoSaveReplayLabel";
            this.autoSaveReplayLabel.Size = new System.Drawing.Size(99, 13);
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
            this.comboBoxBoolOptionsCustomKeys.Location = new System.Drawing.Point(138, 90);
            this.comboBoxBoolOptionsCustomKeys.Name = "comboBoxBoolOptionsCustomKeys";
            this.comboBoxBoolOptionsCustomKeys.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsCustomKeys.TabIndex = 42;
            // 
            // customKeysLabel
            // 
            this.customKeysLabel.AutoSize = true;
            this.customKeysLabel.BackColor = System.Drawing.Color.White;
            this.customKeysLabel.Location = new System.Drawing.Point(6, 90);
            this.customKeysLabel.Name = "customKeysLabel";
            this.customKeysLabel.Size = new System.Drawing.Size(74, 13);
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
            this.comboBoxBoolOptionsDisplayFps.Location = new System.Drawing.Point(398, 63);
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
            this.comboBoxBoolOptionsDisplayPing.Location = new System.Drawing.Point(138, 63);
            this.comboBoxBoolOptionsDisplayPing.Name = "comboBoxBoolOptionsDisplayPing";
            this.comboBoxBoolOptionsDisplayPing.Size = new System.Drawing.Size(130, 21);
            this.comboBoxBoolOptionsDisplayPing.TabIndex = 39;
            // 
            // displayFpsLabel
            // 
            this.displayFpsLabel.AutoSize = true;
            this.displayFpsLabel.BackColor = System.Drawing.Color.White;
            this.displayFpsLabel.Location = new System.Drawing.Point(285, 63);
            this.displayFpsLabel.Name = "displayFpsLabel";
            this.displayFpsLabel.Size = new System.Drawing.Size(70, 13);
            this.displayFpsLabel.TabIndex = 38;
            this.displayFpsLabel.Text = "Display FPS: ";
            // 
            // displayPingLabel
            // 
            this.displayPingLabel.AutoSize = true;
            this.displayPingLabel.BackColor = System.Drawing.Color.White;
            this.displayPingLabel.Location = new System.Drawing.Point(8, 63);
            this.displayPingLabel.Name = "displayPingLabel";
            this.displayPingLabel.Size = new System.Drawing.Size(71, 13);
            this.displayPingLabel.TabIndex = 36;
            this.displayPingLabel.Text = "Display Ping: ";
            // 
            // trackBarLabelMouse_Scroll
            // 
            this.trackBarLabelMouse_Scroll.AutoSize = true;
            this.trackBarLabelMouse_Scroll.BackColor = System.Drawing.Color.White;
            this.trackBarLabelMouse_Scroll.Location = new System.Drawing.Point(287, 23);
            this.trackBarLabelMouse_Scroll.Name = "trackBarLabelMouse_Scroll";
            this.trackBarLabelMouse_Scroll.Size = new System.Drawing.Size(71, 13);
            this.trackBarLabelMouse_Scroll.TabIndex = 34;
            this.trackBarLabelMouse_Scroll.Text = "Mouse Scroll:";
            // 
            // trackBarLabelKey_Scroll
            // 
            this.trackBarLabelKey_Scroll.AutoSize = true;
            this.trackBarLabelKey_Scroll.BackColor = System.Drawing.Color.White;
            this.trackBarLabelKey_Scroll.Location = new System.Drawing.Point(10, 23);
            this.trackBarLabelKey_Scroll.Name = "trackBarLabelKey_Scroll";
            this.trackBarLabelKey_Scroll.Size = new System.Drawing.Size(57, 13);
            this.trackBarLabelKey_Scroll.TabIndex = 32;
            this.trackBarLabelKey_Scroll.Text = "Key Scroll:";
            // 
            // textBoxCampaignProfile
            // 
            this.textBoxCampaignProfile.Location = new System.Drawing.Point(150, 478);
            this.textBoxCampaignProfile.Name = "textBoxCampaignProfile";
            this.textBoxCampaignProfile.Size = new System.Drawing.Size(130, 20);
            this.textBoxCampaignProfile.TabIndex = 32;
            // 
            // campaignProfileLabel
            // 
            this.campaignProfileLabel.AutoSize = true;
            this.campaignProfileLabel.BackColor = System.Drawing.Color.White;
            this.campaignProfileLabel.Location = new System.Drawing.Point(18, 478);
            this.campaignProfileLabel.Name = "campaignProfileLabel";
            this.campaignProfileLabel.Size = new System.Drawing.Size(94, 13);
            this.campaignProfileLabel.TabIndex = 45;
            this.campaignProfileLabel.Text = "Campaign profile:  ";
            // 
            // userLocalLabel
            // 
            this.userLocalLabel.AutoSize = true;
            this.userLocalLabel.BackColor = System.Drawing.Color.White;
            this.userLocalLabel.Location = new System.Drawing.Point(297, 478);
            this.userLocalLabel.Name = "userLocalLabel";
            this.userLocalLabel.Size = new System.Drawing.Size(68, 13);
            this.userLocalLabel.TabIndex = 47;
            this.userLocalLabel.Text = "Profile name:";
            // 
            // textBoxUserLocal
            // 
            this.textBoxUserLocal.Location = new System.Drawing.Point(410, 478);
            this.textBoxUserLocal.Name = "textBoxUserLocal";
            this.textBoxUserLocal.Size = new System.Drawing.Size(130, 20);
            this.textBoxUserLocal.TabIndex = 46;
            // 
            // W3Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(590, 504);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxVideoSettings.ResumeLayout(false);
            this.groupBoxVideoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.groupBoxSoundSettings.ResumeLayout(false);
            this.groupBoxSoundSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSFX_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic_Volume)).EndInit();
            this.groupBoxGameplaySettings.ResumeLayout(false);
            this.groupBoxGameplaySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMouse_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKey_Scroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToTheMainWindowToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsLights;
        private System.Windows.Forms.Label lightsLabel;
        private System.Windows.Forms.Label particlesLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsParticles;
        private System.Windows.Forms.Label animationQualityLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsAnimQuality;
        private System.Windows.Forms.Label textureQualityLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsTexQuality;
        private System.Windows.Forms.Label modelDetailLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsModelDetail;
        private System.Windows.Forms.Label spellDetailLabel;
        private System.Windows.Forms.ComboBox comboBoxThreeOptionsSpellFilter;
        private System.Windows.Forms.Label occlusionLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsOcclusion;
        private System.Windows.Forms.GroupBox groupBoxVideoSettings;
        private System.Windows.Forms.Label unitShadowsLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsUnitShadows;
        private System.Windows.Forms.Label screenResolutionLabel;
        private System.Windows.Forms.ComboBox comboBoxScreenResolution;
        private System.Windows.Forms.Label vsyncLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsVSync;
        private System.Windows.Forms.ComboBox comboBoxWindowMode;
        private System.Windows.Forms.Label windowModeLabel;
        private System.Windows.Forms.ComboBox comboBoxBitOptionsTexColorDepth;
        private System.Windows.Forms.Label texColorDepthLabel;
        private System.Windows.Forms.Label trackBarLabelGamma;
        private System.Windows.Forms.GroupBox groupBoxSoundSettings;
        private System.Windows.Forms.Label trackBarLabelMusic_Volume;
        private System.Windows.Forms.Label trackBarLabelSfx_Volume;
        private System.Windows.Forms.GroupBox groupBoxGameplaySettings;
        private System.Windows.Forms.Label trackBarLabelMouse_Scroll;
        private System.Windows.Forms.Label trackBarLabelKey_Scroll;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsDisplayFps;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsDisplayPing;
        private System.Windows.Forms.Label displayFpsLabel;
        private System.Windows.Forms.Label displayPingLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptions_autosaveReplay;
        private System.Windows.Forms.Label autoSaveReplayLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsCustomKeys;
        private System.Windows.Forms.Label customKeysLabel;
        private System.Windows.Forms.ComboBox comboBoxBoolOptionsSubtitles;
        private System.Windows.Forms.Label subtitlesLabel;
        private System.Windows.Forms.TextBox textBoxCampaignProfile;
        private System.Windows.Forms.Label campaignProfileLabel;
        private System.Windows.Forms.Label userLocalLabel;
        private System.Windows.Forms.TextBox textBoxUserLocal;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.TrackBar trackBarSFX_Volume;
        private System.Windows.Forms.TrackBar trackBarMusic_Volume;
        private System.Windows.Forms.TrackBar trackBarMouse_Scroll;
        private System.Windows.Forms.TrackBar trackBarKey_Scroll;
    }
}