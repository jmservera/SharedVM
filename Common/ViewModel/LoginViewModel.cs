using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
                private Player _selectedPlayer;

        public Player SelectedPlayer
        {
            get { return _selectedPlayer; }
            set { Set(ref _selectedPlayer , value); }
        }

        private List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players { get { return _players; } }

        public LoginViewModel()
        {
            //TODO: retrieve data from file
            _players.Add(new Player { Name = "Kang", PictureUrl = "http://img3.wikia.nocookie.net/__cb20131208164609/simpsons/images/thumb/d/d4/Tapped_Out_Unlock_Kang.png/200px-Tapped_Out_Unlock_Kang.png" });
            _players.Add(new Player { Name = "Bart", PictureUrl = "http://img4.wikia.nocookie.net/__cb20140110020448/simpsons/images/1/14/Bartsimpson2.png" });
        }
    }
}
