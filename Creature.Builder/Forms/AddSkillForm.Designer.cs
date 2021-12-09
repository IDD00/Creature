
namespace Creature.Builder
{
    partial class AddSkillForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(240, 65);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(160, 65);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(15, 15);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(49, 17);
            this.addNameLabel.TabIndex = 4;
            this.addNameLabel.Text = "&Name:";
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addNameTextBox.Location = new System.Drawing.Point(15, 35);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(300, 22);
            this.addNameTextBox.TabIndex = 5;
            this.addNameTextBox.TextChanged += new System.EventHandler(this.addNameTextBox_TextChanged);
            // 
            // AddSkillForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(332, 103);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.addNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSkillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Skill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.TextBox addNameTextBox;
    }
}