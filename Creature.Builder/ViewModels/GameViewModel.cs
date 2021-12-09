using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creature.Data;

namespace Creature.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
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
        public BindingList<Data.Creature> PlayerTeam { get; set; }

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
                        PlayerTeam = new BindingList<Data.Creature>(_game.Player.Team);
                    }
                    else
                    {
                        Creatures = new BindingList<Data.Creature>(Array.Empty<Data.Creature>());
                        PlayerTeam = new BindingList<Data.Creature>(Array.Empty<Data.Creature>());
                    }
                }
            }
        }

        private string _filename;
        private Game _game;
    }
}
