using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creature.Builder
{
    public partial class AddSkillForm : Form
    {
        public string SkillName
        {
            get => addNameTextBox.Text;
            set => addNameTextBox.Text = value;
        }

        public AddSkillForm()
        {
            InitializeComponent();
        }

        private void addNameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(SkillName);
        }
    }
}
