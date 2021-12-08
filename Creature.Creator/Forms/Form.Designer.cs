
namespace Creature.Builder
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.creatureInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.mainFormMenuStrip.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.creaturesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(682, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
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
            this.mainFormTabControl.Size = new System.Drawing.Size(658, 560);
            this.mainFormTabControl.TabIndex = 1;
            // 
            // creaturesTabPage
            // 
            this.creaturesTabPage.Controls.Add(this.creatureInfoGroupBox);
            this.creaturesTabPage.Controls.Add(this.creatureIndexGroupBox);
            this.creaturesTabPage.Location = new System.Drawing.Point(4, 27);
            this.creaturesTabPage.Name = "creaturesTabPage";
            this.creaturesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.creaturesTabPage.Size = new System.Drawing.Size(650, 529);
            this.creaturesTabPage.TabIndex = 0;
            this.creaturesTabPage.Text = "Creatures";
            this.creaturesTabPage.UseVisualStyleBackColor = true;
            // 
            // gameTabPage
            // 
            this.gameTabPage.Location = new System.Drawing.Point(4, 27);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(650, 479);
            this.gameTabPage.TabIndex = 1;
            this.gameTabPage.Text = "Game";
            this.gameTabPage.UseVisualStyleBackColor = true;
            // 
            // creatureIndexGroupBox
            // 
            this.creatureIndexGroupBox.Location = new System.Drawing.Point(6, 6);
            this.creatureIndexGroupBox.Name = "creatureIndexGroupBox";
            this.creatureIndexGroupBox.Size = new System.Drawing.Size(180, 510);
            this.creatureIndexGroupBox.TabIndex = 0;
            this.creatureIndexGroupBox.TabStop = false;
            this.creatureIndexGroupBox.Text = "Creature Index";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Game Files (*.json)|*.json";
            // 
            // creatureInfoGroupBox
            // 
            this.creatureInfoGroupBox.Location = new System.Drawing.Point(192, 6);
            this.creatureInfoGroupBox.Name = "creatureInfoGroupBox";
            this.creatureInfoGroupBox.Size = new System.Drawing.Size(450, 500);
            this.creatureInfoGroupBox.TabIndex = 1;
            this.creatureInfoGroupBox.TabStop = false;
            this.creatureInfoGroupBox.Text = "Creature Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.mainFormTabControl);
            this.Controls.Add(this.mainFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Creature Builder";
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.mainFormTabControl.ResumeLayout(false);
            this.creaturesTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox creatureIndexGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox creatureInfoGroupBox;
    }
}

