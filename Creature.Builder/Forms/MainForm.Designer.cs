
namespace Creature.Builder
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
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormTabControl = new System.Windows.Forms.TabControl();
            this.creaturesTabPage = new System.Windows.Forms.TabPage();
            this.gameTabPage = new System.Windows.Forms.TabPage();
            this.creatureIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.creatureInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.skillInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.messagesGroupBox = new System.Windows.Forms.GroupBox();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerTeamListBox = new System.Windows.Forms.ListBox();
            this.creatureIndexListBox = new System.Windows.Forms.ListBox();
            this.newCreatureButton = new System.Windows.Forms.Button();
            this.deleteCreatureButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.creatureNameLabel = new System.Windows.Forms.Label();
            this.creatureDescriptionLabel = new System.Windows.Forms.Label();
            this.creatureWeaknessLabel = new System.Windows.Forms.Label();
            this.creatureResistanceLabel = new System.Windows.Forms.Label();
            this.creatureHealthLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.creatureWeaknessComboBox = new System.Windows.Forms.ComboBox();
            this.creatureResistanceComboBox = new System.Windows.Forms.ComboBox();
            this.skillDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.skillDescriptionLabel = new System.Windows.Forms.Label();
            this.skillNameLabel = new System.Windows.Forms.Label();
            this.skillNameTextBox = new System.Windows.Forms.TextBox();
            this.skillElementLabel = new System.Windows.Forms.Label();
            this.skillElementComboBox = new System.Windows.Forms.ComboBox();
            this.healthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.creatureSkillsListBox = new System.Windows.Forms.ListBox();
            this.addSkillButton = new System.Windows.Forms.Button();
            this.removeSkillButton = new System.Windows.Forms.Button();
            this.creatureSkillSetLabel = new System.Windows.Forms.Label();
            this.skillPowerLabel = new System.Windows.Forms.Label();
            this.skillRecoverLabel = new System.Windows.Forms.Label();
            this.skillChargeLabel = new System.Windows.Forms.Label();
            this.skillArmorLabel = new System.Windows.Forms.Label();
            this.skillPowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skillChargeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skillArmorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skillRecoverNumericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.creaturesListBox = new System.Windows.Forms.ListBox();
            this.creaturesLabel = new System.Windows.Forms.Label();
            this.startingCreaturesLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.startMessageTextBox = new System.Windows.Forms.TextBox();
            this.startMessageLabel = new System.Windows.Forms.Label();
            this.exitMessageLabel = new System.Windows.Forms.Label();
            this.exitMessageTextBox = new System.Windows.Forms.TextBox();
            this.mainFormMenuStrip.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.creaturesTabPage.SuspendLayout();
            this.gameTabPage.SuspendLayout();
            this.creatureIndexGroupBox.SuspendLayout();
            this.creatureInfoGroupBox.SuspendLayout();
            this.skillInfoGroupBox.SuspendLayout();
            this.messagesGroupBox.SuspendLayout();
            this.playerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillChargeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillArmorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillRecoverNumericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(882, 30);
            this.mainFormMenuStrip.TabIndex = 0;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // mainFormTabControl
            // 
            this.mainFormTabControl.Controls.Add(this.creaturesTabPage);
            this.mainFormTabControl.Controls.Add(this.gameTabPage);
            this.mainFormTabControl.Location = new System.Drawing.Point(12, 31);
            this.mainFormTabControl.Name = "mainFormTabControl";
            this.mainFormTabControl.SelectedIndex = 0;
            this.mainFormTabControl.Size = new System.Drawing.Size(858, 510);
            this.mainFormTabControl.TabIndex = 1;
            // 
            // creaturesTabPage
            // 
            this.creaturesTabPage.Controls.Add(this.creatureInfoGroupBox);
            this.creaturesTabPage.Controls.Add(this.creatureIndexGroupBox);
            this.creaturesTabPage.Location = new System.Drawing.Point(4, 25);
            this.creaturesTabPage.Name = "creaturesTabPage";
            this.creaturesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.creaturesTabPage.Size = new System.Drawing.Size(850, 481);
            this.creaturesTabPage.TabIndex = 0;
            this.creaturesTabPage.Text = "Creatures";
            this.creaturesTabPage.UseVisualStyleBackColor = true;
            // 
            // gameTabPage
            // 
            this.gameTabPage.Controls.Add(this.playerGroupBox);
            this.gameTabPage.Controls.Add(this.messagesGroupBox);
            this.gameTabPage.Location = new System.Drawing.Point(4, 25);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(850, 481);
            this.gameTabPage.TabIndex = 1;
            this.gameTabPage.Text = "Game";
            this.gameTabPage.UseVisualStyleBackColor = true;
            // 
            // creatureIndexGroupBox
            // 
            this.creatureIndexGroupBox.Controls.Add(this.deleteCreatureButton);
            this.creatureIndexGroupBox.Controls.Add(this.newCreatureButton);
            this.creatureIndexGroupBox.Controls.Add(this.creatureIndexListBox);
            this.creatureIndexGroupBox.Location = new System.Drawing.Point(9, 6);
            this.creatureIndexGroupBox.Name = "creatureIndexGroupBox";
            this.creatureIndexGroupBox.Size = new System.Drawing.Size(180, 460);
            this.creatureIndexGroupBox.TabIndex = 0;
            this.creatureIndexGroupBox.TabStop = false;
            this.creatureIndexGroupBox.Text = "&Creature Index";
            // 
            // creatureInfoGroupBox
            // 
            this.creatureInfoGroupBox.Controls.Add(this.creatureSkillSetLabel);
            this.creatureInfoGroupBox.Controls.Add(this.removeSkillButton);
            this.creatureInfoGroupBox.Controls.Add(this.healthNumericUpDown);
            this.creatureInfoGroupBox.Controls.Add(this.creatureResistanceComboBox);
            this.creatureInfoGroupBox.Controls.Add(this.addSkillButton);
            this.creatureInfoGroupBox.Controls.Add(this.skillInfoGroupBox);
            this.creatureInfoGroupBox.Controls.Add(this.creatureWeaknessComboBox);
            this.creatureInfoGroupBox.Controls.Add(this.creatureSkillsListBox);
            this.creatureInfoGroupBox.Controls.Add(this.textBox2);
            this.creatureInfoGroupBox.Controls.Add(this.creatureHealthLabel);
            this.creatureInfoGroupBox.Controls.Add(this.creatureResistanceLabel);
            this.creatureInfoGroupBox.Controls.Add(this.creatureWeaknessLabel);
            this.creatureInfoGroupBox.Controls.Add(this.creatureDescriptionLabel);
            this.creatureInfoGroupBox.Controls.Add(this.creatureNameLabel);
            this.creatureInfoGroupBox.Controls.Add(this.nameTextBox);
            this.creatureInfoGroupBox.Location = new System.Drawing.Point(200, 6);
            this.creatureInfoGroupBox.Name = "creatureInfoGroupBox";
            this.creatureInfoGroupBox.Size = new System.Drawing.Size(640, 460);
            this.creatureInfoGroupBox.TabIndex = 1;
            this.creatureInfoGroupBox.TabStop = false;
            this.creatureInfoGroupBox.Text = "&Creature Information";
            // 
            // skillInfoGroupBox
            // 
            this.skillInfoGroupBox.Controls.Add(this.skillRecoverNumericUpDown5);
            this.skillInfoGroupBox.Controls.Add(this.skillArmorNumericUpDown);
            this.skillInfoGroupBox.Controls.Add(this.skillChargeNumericUpDown);
            this.skillInfoGroupBox.Controls.Add(this.skillPowerNumericUpDown);
            this.skillInfoGroupBox.Controls.Add(this.skillArmorLabel);
            this.skillInfoGroupBox.Controls.Add(this.skillChargeLabel);
            this.skillInfoGroupBox.Controls.Add(this.skillRecoverLabel);
            this.skillInfoGroupBox.Controls.Add(this.skillPowerLabel);
            this.skillInfoGroupBox.Controls.Add(this.skillElementComboBox);
            this.skillInfoGroupBox.Controls.Add(this.skillElementLabel);
            this.skillInfoGroupBox.Controls.Add(this.skillDescriptionTextBox);
            this.skillInfoGroupBox.Controls.Add(this.skillDescriptionLabel);
            this.skillInfoGroupBox.Controls.Add(this.skillNameTextBox);
            this.skillInfoGroupBox.Controls.Add(this.skillNameLabel);
            this.skillInfoGroupBox.Location = new System.Drawing.Point(195, 190);
            this.skillInfoGroupBox.Name = "skillInfoGroupBox";
            this.skillInfoGroupBox.Size = new System.Drawing.Size(430, 260);
            this.skillInfoGroupBox.TabIndex = 0;
            this.skillInfoGroupBox.TabStop = false;
            this.skillInfoGroupBox.Text = "&Skill Information";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Game Files (*.json)|*.json";
            // 
            // messagesGroupBox
            // 
            this.messagesGroupBox.Controls.Add(this.exitMessageTextBox);
            this.messagesGroupBox.Controls.Add(this.exitMessageLabel);
            this.messagesGroupBox.Controls.Add(this.startMessageLabel);
            this.messagesGroupBox.Controls.Add(this.startMessageTextBox);
            this.messagesGroupBox.Location = new System.Drawing.Point(230, 50);
            this.messagesGroupBox.Name = "messagesGroupBox";
            this.messagesGroupBox.Size = new System.Drawing.Size(600, 330);
            this.messagesGroupBox.TabIndex = 0;
            this.messagesGroupBox.TabStop = false;
            this.messagesGroupBox.Text = "Messages";
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.removeTeamButton);
            this.playerGroupBox.Controls.Add(this.startingCreaturesLabel);
            this.playerGroupBox.Controls.Add(this.addTeamButton);
            this.playerGroupBox.Controls.Add(this.creaturesListBox);
            this.playerGroupBox.Controls.Add(this.creaturesLabel);
            this.playerGroupBox.Controls.Add(this.playerTeamListBox);
            this.playerGroupBox.Location = new System.Drawing.Point(15, 6);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(200, 450);
            this.playerGroupBox.TabIndex = 1;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "&Player Team";
            // 
            // playerTeamListBox
            // 
            this.playerTeamListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerTeamListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamListBox.FormattingEnabled = true;
            this.playerTeamListBox.ItemHeight = 16;
            this.playerTeamListBox.Location = new System.Drawing.Point(15, 250);
            this.playerTeamListBox.Name = "playerTeamListBox";
            this.playerTeamListBox.Size = new System.Drawing.Size(160, 146);
            this.playerTeamListBox.TabIndex = 0;
            // 
            // creatureIndexListBox
            // 
            this.creatureIndexListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creatureIndexListBox.FormattingEnabled = true;
            this.creatureIndexListBox.ItemHeight = 16;
            this.creatureIndexListBox.Location = new System.Drawing.Point(15, 25);
            this.creatureIndexListBox.Name = "creatureIndexListBox";
            this.creatureIndexListBox.Size = new System.Drawing.Size(150, 386);
            this.creatureIndexListBox.TabIndex = 1;
            // 
            // newCreatureButton
            // 
            this.newCreatureButton.Location = new System.Drawing.Point(9, 420);
            this.newCreatureButton.Name = "newCreatureButton";
            this.newCreatureButton.Size = new System.Drawing.Size(75, 25);
            this.newCreatureButton.TabIndex = 1;
            this.newCreatureButton.Text = "&New";
            this.newCreatureButton.UseVisualStyleBackColor = true;
            // 
            // deleteCreatureButton
            // 
            this.deleteCreatureButton.Location = new System.Drawing.Point(96, 420);
            this.deleteCreatureButton.Name = "deleteCreatureButton";
            this.deleteCreatureButton.Size = new System.Drawing.Size(75, 25);
            this.deleteCreatureButton.TabIndex = 2;
            this.deleteCreatureButton.Text = "&Delete";
            this.deleteCreatureButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(30, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // creatureNameLabel
            // 
            this.creatureNameLabel.AutoSize = true;
            this.creatureNameLabel.Location = new System.Drawing.Point(27, 27);
            this.creatureNameLabel.Name = "creatureNameLabel";
            this.creatureNameLabel.Size = new System.Drawing.Size(49, 17);
            this.creatureNameLabel.TabIndex = 2;
            this.creatureNameLabel.Text = "&Name:";
            // 
            // creatureDescriptionLabel
            // 
            this.creatureDescriptionLabel.AutoSize = true;
            this.creatureDescriptionLabel.Location = new System.Drawing.Point(311, 27);
            this.creatureDescriptionLabel.Name = "creatureDescriptionLabel";
            this.creatureDescriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.creatureDescriptionLabel.TabIndex = 3;
            this.creatureDescriptionLabel.Text = "&Description:";
            // 
            // creatureWeaknessLabel
            // 
            this.creatureWeaknessLabel.AutoSize = true;
            this.creatureWeaknessLabel.Location = new System.Drawing.Point(29, 86);
            this.creatureWeaknessLabel.Name = "creatureWeaknessLabel";
            this.creatureWeaknessLabel.Size = new System.Drawing.Size(78, 17);
            this.creatureWeaknessLabel.TabIndex = 4;
            this.creatureWeaknessLabel.Text = "&Weakness:";
            // 
            // creatureResistanceLabel
            // 
            this.creatureResistanceLabel.AutoSize = true;
            this.creatureResistanceLabel.Location = new System.Drawing.Point(29, 121);
            this.creatureResistanceLabel.Name = "creatureResistanceLabel";
            this.creatureResistanceLabel.Size = new System.Drawing.Size(82, 17);
            this.creatureResistanceLabel.TabIndex = 5;
            this.creatureResistanceLabel.Text = "&Resistance:";
            // 
            // creatureHealthLabel
            // 
            this.creatureHealthLabel.AutoSize = true;
            this.creatureHealthLabel.Location = new System.Drawing.Point(29, 155);
            this.creatureHealthLabel.Name = "creatureHealthLabel";
            this.creatureHealthLabel.Size = new System.Drawing.Size(53, 17);
            this.creatureHealthLabel.TabIndex = 6;
            this.creatureHealthLabel.Text = "&Health:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(314, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 100);
            this.textBox2.TabIndex = 7;
            // 
            // creatureWeaknessComboBox
            // 
            this.creatureWeaknessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creatureWeaknessComboBox.FormattingEnabled = true;
            this.creatureWeaknessComboBox.Location = new System.Drawing.Point(130, 83);
            this.creatureWeaknessComboBox.Name = "creatureWeaknessComboBox";
            this.creatureWeaknessComboBox.Size = new System.Drawing.Size(150, 24);
            this.creatureWeaknessComboBox.TabIndex = 8;
            // 
            // creatureResistanceComboBox
            // 
            this.creatureResistanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creatureResistanceComboBox.FormattingEnabled = true;
            this.creatureResistanceComboBox.Location = new System.Drawing.Point(130, 118);
            this.creatureResistanceComboBox.Name = "creatureResistanceComboBox";
            this.creatureResistanceComboBox.Size = new System.Drawing.Size(150, 24);
            this.creatureResistanceComboBox.TabIndex = 9;
            // 
            // skillDescriptionTextBox
            // 
            this.skillDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillDescriptionTextBox.Location = new System.Drawing.Point(18, 95);
            this.skillDescriptionTextBox.Multiline = true;
            this.skillDescriptionTextBox.Name = "skillDescriptionTextBox";
            this.skillDescriptionTextBox.Size = new System.Drawing.Size(250, 100);
            this.skillDescriptionTextBox.TabIndex = 13;
            // 
            // skillDescriptionLabel
            // 
            this.skillDescriptionLabel.AutoSize = true;
            this.skillDescriptionLabel.Location = new System.Drawing.Point(15, 75);
            this.skillDescriptionLabel.Name = "skillDescriptionLabel";
            this.skillDescriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.skillDescriptionLabel.TabIndex = 12;
            this.skillDescriptionLabel.Text = "&Description:";
            // 
            // skillNameLabel
            // 
            this.skillNameLabel.AutoSize = true;
            this.skillNameLabel.Location = new System.Drawing.Point(15, 25);
            this.skillNameLabel.Name = "skillNameLabel";
            this.skillNameLabel.Size = new System.Drawing.Size(49, 17);
            this.skillNameLabel.TabIndex = 11;
            this.skillNameLabel.Text = "&Name:";
            // 
            // skillNameTextBox
            // 
            this.skillNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillNameTextBox.Location = new System.Drawing.Point(18, 45);
            this.skillNameTextBox.Name = "skillNameTextBox";
            this.skillNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.skillNameTextBox.TabIndex = 10;
            // 
            // skillElementLabel
            // 
            this.skillElementLabel.AutoSize = true;
            this.skillElementLabel.Location = new System.Drawing.Point(15, 215);
            this.skillElementLabel.Name = "skillElementLabel";
            this.skillElementLabel.Size = new System.Drawing.Size(63, 17);
            this.skillElementLabel.TabIndex = 10;
            this.skillElementLabel.Text = "&Element:";
            // 
            // skillElementComboBox
            // 
            this.skillElementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillElementComboBox.FormattingEnabled = true;
            this.skillElementComboBox.Location = new System.Drawing.Point(118, 212);
            this.skillElementComboBox.Name = "skillElementComboBox";
            this.skillElementComboBox.Size = new System.Drawing.Size(150, 24);
            this.skillElementComboBox.TabIndex = 10;
            // 
            // healthNumericUpDown
            // 
            this.healthNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthNumericUpDown.Location = new System.Drawing.Point(160, 153);
            this.healthNumericUpDown.Name = "healthNumericUpDown";
            this.healthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.healthNumericUpDown.TabIndex = 10;
            // 
            // creatureSkillsListBox
            // 
            this.creatureSkillsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creatureSkillsListBox.FormattingEnabled = true;
            this.creatureSkillsListBox.ItemHeight = 16;
            this.creatureSkillsListBox.Location = new System.Drawing.Point(20, 215);
            this.creatureSkillsListBox.Name = "creatureSkillsListBox";
            this.creatureSkillsListBox.Size = new System.Drawing.Size(160, 194);
            this.creatureSkillsListBox.TabIndex = 3;
            // 
            // addSkillButton
            // 
            this.addSkillButton.Location = new System.Drawing.Point(20, 420);
            this.addSkillButton.Name = "addSkillButton";
            this.addSkillButton.Size = new System.Drawing.Size(75, 25);
            this.addSkillButton.TabIndex = 4;
            this.addSkillButton.Text = "&Add";
            this.addSkillButton.UseVisualStyleBackColor = true;
            // 
            // removeSkillButton
            // 
            this.removeSkillButton.Location = new System.Drawing.Point(105, 420);
            this.removeSkillButton.Name = "removeSkillButton";
            this.removeSkillButton.Size = new System.Drawing.Size(75, 25);
            this.removeSkillButton.TabIndex = 5;
            this.removeSkillButton.Text = "&Remove";
            this.removeSkillButton.UseVisualStyleBackColor = true;
            // 
            // creatureSkillSetLabel
            // 
            this.creatureSkillSetLabel.AutoSize = true;
            this.creatureSkillSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureSkillSetLabel.Location = new System.Drawing.Point(15, 195);
            this.creatureSkillSetLabel.Name = "creatureSkillSetLabel";
            this.creatureSkillSetLabel.Size = new System.Drawing.Size(103, 17);
            this.creatureSkillSetLabel.TabIndex = 11;
            this.creatureSkillSetLabel.Text = "&Creature Skills:";
            // 
            // skillPowerLabel
            // 
            this.skillPowerLabel.AutoSize = true;
            this.skillPowerLabel.Location = new System.Drawing.Point(290, 25);
            this.skillPowerLabel.Name = "skillPowerLabel";
            this.skillPowerLabel.Size = new System.Drawing.Size(51, 17);
            this.skillPowerLabel.TabIndex = 14;
            this.skillPowerLabel.Text = "&Power:";
            // 
            // skillRecoverLabel
            // 
            this.skillRecoverLabel.AutoSize = true;
            this.skillRecoverLabel.Location = new System.Drawing.Point(290, 190);
            this.skillRecoverLabel.Name = "skillRecoverLabel";
            this.skillRecoverLabel.Size = new System.Drawing.Size(65, 17);
            this.skillRecoverLabel.TabIndex = 15;
            this.skillRecoverLabel.Text = "&Recover:";
            // 
            // skillChargeLabel
            // 
            this.skillChargeLabel.AutoSize = true;
            this.skillChargeLabel.Location = new System.Drawing.Point(290, 80);
            this.skillChargeLabel.Name = "skillChargeLabel";
            this.skillChargeLabel.Size = new System.Drawing.Size(58, 17);
            this.skillChargeLabel.TabIndex = 15;
            this.skillChargeLabel.Text = "&Charge:";
            // 
            // skillArmorLabel
            // 
            this.skillArmorLabel.AutoSize = true;
            this.skillArmorLabel.Location = new System.Drawing.Point(290, 135);
            this.skillArmorLabel.Name = "skillArmorLabel";
            this.skillArmorLabel.Size = new System.Drawing.Size(50, 17);
            this.skillArmorLabel.TabIndex = 16;
            this.skillArmorLabel.Text = "&Armor:";
            // 
            // skillPowerNumericUpDown
            // 
            this.skillPowerNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillPowerNumericUpDown.Location = new System.Drawing.Point(293, 45);
            this.skillPowerNumericUpDown.Name = "skillPowerNumericUpDown";
            this.skillPowerNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.skillPowerNumericUpDown.TabIndex = 12;
            // 
            // skillChargeNumericUpDown
            // 
            this.skillChargeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillChargeNumericUpDown.Location = new System.Drawing.Point(293, 100);
            this.skillChargeNumericUpDown.Name = "skillChargeNumericUpDown";
            this.skillChargeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.skillChargeNumericUpDown.TabIndex = 17;
            // 
            // skillArmorNumericUpDown
            // 
            this.skillArmorNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillArmorNumericUpDown.Location = new System.Drawing.Point(293, 155);
            this.skillArmorNumericUpDown.Name = "skillArmorNumericUpDown";
            this.skillArmorNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.skillArmorNumericUpDown.TabIndex = 18;
            // 
            // skillRecoverNumericUpDown5
            // 
            this.skillRecoverNumericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skillRecoverNumericUpDown5.Location = new System.Drawing.Point(293, 210);
            this.skillRecoverNumericUpDown5.Name = "skillRecoverNumericUpDown5";
            this.skillRecoverNumericUpDown5.Size = new System.Drawing.Size(120, 22);
            this.skillRecoverNumericUpDown5.TabIndex = 19;
            // 
            // creaturesListBox
            // 
            this.creaturesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creaturesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaturesListBox.FormattingEnabled = true;
            this.creaturesListBox.ItemHeight = 16;
            this.creaturesListBox.Location = new System.Drawing.Point(15, 45);
            this.creaturesListBox.Name = "creaturesListBox";
            this.creaturesListBox.Size = new System.Drawing.Size(160, 178);
            this.creaturesListBox.TabIndex = 1;
            // 
            // creaturesLabel
            // 
            this.creaturesLabel.AutoSize = true;
            this.creaturesLabel.Location = new System.Drawing.Point(10, 25);
            this.creaturesLabel.Name = "creaturesLabel";
            this.creaturesLabel.Size = new System.Drawing.Size(74, 17);
            this.creaturesLabel.TabIndex = 0;
            this.creaturesLabel.Text = "&Creatures:";
            // 
            // startingCreaturesLabel
            // 
            this.startingCreaturesLabel.AutoSize = true;
            this.startingCreaturesLabel.Location = new System.Drawing.Point(10, 230);
            this.startingCreaturesLabel.Name = "startingCreaturesLabel";
            this.startingCreaturesLabel.Size = new System.Drawing.Size(127, 17);
            this.startingCreaturesLabel.TabIndex = 1;
            this.startingCreaturesLabel.Text = "&Starting Creatures:";
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(15, 410);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(75, 25);
            this.addTeamButton.TabIndex = 0;
            this.addTeamButton.Text = "&Add";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // removeTeamButton
            // 
            this.removeTeamButton.Location = new System.Drawing.Point(100, 410);
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Size = new System.Drawing.Size(75, 25);
            this.removeTeamButton.TabIndex = 1;
            this.removeTeamButton.Text = "&Remove";
            this.removeTeamButton.UseVisualStyleBackColor = true;
            // 
            // startMessageTextBox
            // 
            this.startMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startMessageTextBox.Location = new System.Drawing.Point(45, 55);
            this.startMessageTextBox.Multiline = true;
            this.startMessageTextBox.Name = "startMessageTextBox";
            this.startMessageTextBox.Size = new System.Drawing.Size(500, 100);
            this.startMessageTextBox.TabIndex = 1;
            // 
            // startMessageLabel
            // 
            this.startMessageLabel.AutoSize = true;
            this.startMessageLabel.Location = new System.Drawing.Point(40, 30);
            this.startMessageLabel.Name = "startMessageLabel";
            this.startMessageLabel.Size = new System.Drawing.Size(103, 17);
            this.startMessageLabel.TabIndex = 2;
            this.startMessageLabel.Text = "&Start Message:";
            // 
            // exitMessageLabel
            // 
            this.exitMessageLabel.AutoSize = true;
            this.exitMessageLabel.Location = new System.Drawing.Point(40, 180);
            this.exitMessageLabel.Name = "exitMessageLabel";
            this.exitMessageLabel.Size = new System.Drawing.Size(95, 17);
            this.exitMessageLabel.TabIndex = 3;
            this.exitMessageLabel.Text = "&Exit Message:";
            // 
            // exitMessageTextBox
            // 
            this.exitMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitMessageTextBox.Location = new System.Drawing.Point(45, 205);
            this.exitMessageTextBox.Multiline = true;
            this.exitMessageTextBox.Name = "exitMessageTextBox";
            this.exitMessageTextBox.Size = new System.Drawing.Size(500, 100);
            this.exitMessageTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.mainFormTabControl);
            this.Controls.Add(this.mainFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Creature Builder";
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.mainFormTabControl.ResumeLayout(false);
            this.creaturesTabPage.ResumeLayout(false);
            this.gameTabPage.ResumeLayout(false);
            this.creatureIndexGroupBox.ResumeLayout(false);
            this.creatureInfoGroupBox.ResumeLayout(false);
            this.creatureInfoGroupBox.PerformLayout();
            this.skillInfoGroupBox.ResumeLayout(false);
            this.skillInfoGroupBox.PerformLayout();
            this.messagesGroupBox.ResumeLayout(false);
            this.messagesGroupBox.PerformLayout();
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillChargeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillArmorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillRecoverNumericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl mainFormTabControl;
        private System.Windows.Forms.TabPage creaturesTabPage;
        private System.Windows.Forms.TabPage gameTabPage;
        private System.Windows.Forms.GroupBox creatureInfoGroupBox;
        private System.Windows.Forms.GroupBox creatureIndexGroupBox;
        private System.Windows.Forms.GroupBox skillInfoGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.GroupBox messagesGroupBox;
        private System.Windows.Forms.ListBox playerTeamListBox;
        private System.Windows.Forms.Button deleteCreatureButton;
        private System.Windows.Forms.Button newCreatureButton;
        private System.Windows.Forms.ListBox creatureIndexListBox;
        private System.Windows.Forms.Label creatureNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label creatureResistanceLabel;
        private System.Windows.Forms.Label creatureWeaknessLabel;
        private System.Windows.Forms.Label creatureDescriptionLabel;
        private System.Windows.Forms.Label creatureHealthLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox creatureResistanceComboBox;
        private System.Windows.Forms.ComboBox creatureWeaknessComboBox;
        private System.Windows.Forms.ComboBox skillElementComboBox;
        private System.Windows.Forms.Label skillElementLabel;
        private System.Windows.Forms.TextBox skillDescriptionTextBox;
        private System.Windows.Forms.Label skillDescriptionLabel;
        private System.Windows.Forms.TextBox skillNameTextBox;
        private System.Windows.Forms.Label skillNameLabel;
        private System.Windows.Forms.NumericUpDown healthNumericUpDown;
        private System.Windows.Forms.Label creatureSkillSetLabel;
        private System.Windows.Forms.Button removeSkillButton;
        private System.Windows.Forms.Button addSkillButton;
        private System.Windows.Forms.ListBox creatureSkillsListBox;
        private System.Windows.Forms.NumericUpDown skillRecoverNumericUpDown5;
        private System.Windows.Forms.NumericUpDown skillArmorNumericUpDown;
        private System.Windows.Forms.NumericUpDown skillChargeNumericUpDown;
        private System.Windows.Forms.NumericUpDown skillPowerNumericUpDown;
        private System.Windows.Forms.Label skillArmorLabel;
        private System.Windows.Forms.Label skillChargeLabel;
        private System.Windows.Forms.Label skillRecoverLabel;
        private System.Windows.Forms.Label skillPowerLabel;
        private System.Windows.Forms.ListBox creaturesListBox;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.Label startingCreaturesLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Label creaturesLabel;
        private System.Windows.Forms.TextBox exitMessageTextBox;
        private System.Windows.Forms.Label exitMessageLabel;
        private System.Windows.Forms.Label startMessageLabel;
        private System.Windows.Forms.TextBox startMessageTextBox;
    }
}

