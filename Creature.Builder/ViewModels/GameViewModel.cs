using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Creature.Data;

namespace Creature.Builder.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename
        {
            get => _filename;
            set
            {
                if (_filename != value)
                {
                    _filename = value;
                }
            }
        }

        public BindingList<Data.Creature> Creatures { get; set; }

        public Game Game
        {
            get => _game; 
            set
            {
                if (_game != value)
                {
                    _game = value;

                    if (_game != null)
                    {
                        Creatures = new BindingList<Data.Creature>(_game.World.CreatureIndex);
                    }
                    else
                    {
                        Creatures = new BindingList<Data.Creature>(Array.Empty<Data.Creature>());
                    }
                }
            }
        }

        private string _filename;
        private Game _game;
    }
}
