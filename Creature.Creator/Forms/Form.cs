﻿using Creature.Builder.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Creature.Data;
using System.IO;

namespace Creature.Builder
{
    public partial class Form : System.Windows.Forms.Form
    {
        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                }
            }
        }

        private bool IsGameLoaded
        {
            get => _isGameLoaded; 
            set
            {
                _isGameLoaded = value;
            }
        }

        public Form()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            IsGameLoaded = false;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private GameViewModel _viewModel;
        private bool _isGameLoaded;
    }
}
