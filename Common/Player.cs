using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Player:ObservableObject
    {
        private string _pictureUrl;

        public string PictureUrl
        {
            get { return _pictureUrl; }
            set { Set(ref _pictureUrl , value); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { Set(ref _name , value); }
        }

    }
}
