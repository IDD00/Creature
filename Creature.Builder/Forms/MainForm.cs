using Creature.Builder.ViewModels;
using Creature.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creature.Builder
{
    public partial class MainForm : Form
    {

        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        private bool IsGameLoaded
        {
            get => _isGameLoaded;
            set
            {
                _isGameLoaded = value;
                mainFormTabControl.Enabled = _isGameLoaded;
                closeToolStripMenuItem.Enabled = _isGameLoaded;
                saveToolStripMenuItem.Enabled = _isGameLoaded;
                saveAsToolStripMenuItem.Enabled = _isGameLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            IsGameLoaded = false;

            _comboBoxes = new List<ComboBox>
            {
                { skillElementComboBox },
                { creatureWeaknessComboBox },
                { creatureResistanceComboBox }
            };

            foreach (ComboBox comboBox in _comboBoxes)
            {
                var elements = new List<string>();
                foreach (string element in Enum.GetNames(typeof(Elements)))
                {
                    elements.Add(element);
                }
                comboBox.DataSource = elements;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            World _world = new World();
            Player _player = new Player();

            ViewModel.Game = new Game(_world, _player);

            IsGameLoaded = true;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;

                IsGameLoaded = true;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.Game = null;
            IsGameLoaded = false;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ViewModel.Filename != null)
            {
                SaveGame();
            }
            else
            {
                saveAsToolStripMenuItem.PerformClick();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                SaveGame();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewCreatureButton_Click(object sender, EventArgs e)
        {
            using (AddCreatureForm addCreatureForm = new AddCreatureForm())
            {
                if (addCreatureForm.ShowDialog() == DialogResult.OK)
                {
                    Data.Creature creature = new Data.Creature(addCreatureForm.CreatureName);
                    ViewModel.Creatures.Add(creature);

                    creatureIndexListBox.SelectedItem = ViewModel.Creatures.LastOrDefault();
                }
            }
        }

        private void DeleteCreatureButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Creature?", "Creature Builder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Creatures.Remove((Data.Creature)creatureIndexListBox.SelectedItem);
                creatureIndexListBox.SelectedItem = ViewModel.Creatures.FirstOrDefault();
            }
        }

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            using (AddSkillForm addSkillForm = new AddSkillForm())
            {
                if (addSkillForm.ShowDialog() == DialogResult.OK)
                {
                    Skill skill = new Skill(addSkillForm.SkillName);
                    ViewModel.Creatures[creatureIndexListBox.SelectedIndex].SkillSet.Add(skill);

                    creatureSkillsListBox.SelectedItem = ViewModel.Creatures[creatureIndexListBox.SelectedIndex].SkillSet.FirstOrDefault();
                }
            }
        }

        private void RemoveSkillButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove this Skill?", "Creature Builder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Creatures[creatureIndexListBox.SelectedIndex].SkillSet.Remove((Skill)creatureSkillsListBox.SelectedItem);
                creatureSkillsListBox.SelectedItem = ViewModel.Creatures[creatureIndexListBox.SelectedIndex].SkillSet.FirstOrDefault();
            }
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add selected Creature to Player Team?", "Creature Builder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Creature creature = ViewModel.Creatures[creaturesListBox.SelectedIndex];
                ViewModel.PlayerTeam.Add(new Data.Creature(creature.Name, creature.MaxHealth, creature.Weakness, creature.Resistance, creature.Description));
                ViewModel.Game.Player.TeamNames.Add(creature.Name);
            }
        }

        private void RemoveTeamButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove selected Creature from Player Team?", "Creature Builder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Game.Player.TeamNames.RemoveAt(playerTeamListBox.SelectedIndex);
                ViewModel.PlayerTeam.Remove((Data.Creature)playerTeamListBox.SelectedItem);
                playerTeamListBox.SelectedItem = ViewModel.PlayerTeam.FirstOrDefault();
            }
        }

        private void SaveGame()
        {

            if (string.IsNullOrEmpty(ViewModel.Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(ViewModel.Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, ViewModel.Game);
            }
        }

        private GameViewModel _viewModel;
        private bool _isGameLoaded;

        private readonly List<ComboBox> _comboBoxes;

        private void CreatureIndexListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteCreatureButton.Enabled = creatureIndexListBox.SelectedItem != null;
        }
    }
}
