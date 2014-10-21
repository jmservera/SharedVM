using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Common.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        ViewModelBase _current;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _current;
            }
            set
            {
                Set(ref _current , value);
            }
        }

        public ICommand NavigateTo { get; private set; }
        public MainViewModel()
        {
            NavigateTo = new RelayCommand<string>(ExecuteNavigation, CanExecuteNavigation);

            //default vm
            CurrentViewModel = SimpleIoc.Default.GetInstance<LoginViewModel>();
        }

        private void ExecuteNavigation(string view)
        {

        }


        private bool CanExecuteNavigation(string view)
        {
            return true;
        }
    }
}
