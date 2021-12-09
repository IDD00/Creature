
namespace Creature.Builder
{
    partial class AddCreatureForm
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
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addNameTextBox.Location = new System.Drawing.Point(15, 35);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(300, 22);
            this.addNameTextBox.TabIndex = 1;
            this.addNameTextBox.TextChanged += new System.EventHandler(this.addNameTextBox_TextChanged);
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(15, 15);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(49, 17);
            this.addNameLabel.TabIndex = 0;
            this.addNameLabel.Text = "&Name:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(160, 65);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(240, 65);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddCreatureForm
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
            this.Name = "AddCreatureForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Creature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}