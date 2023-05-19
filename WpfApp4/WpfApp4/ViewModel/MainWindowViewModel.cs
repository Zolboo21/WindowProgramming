using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp4.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        ICommand buttonCommand;

        public ICommand ButtonCommand
        {
            get
            {
                return buttonCommand;
            }
        }

        public MainWindowViewModel()
        {
            buttonCommand = new RelayCommand(ExecuteCommand);
        }

        private void ExecuteCommand()
        {
            MessageBox.Show("Receive Command");
        }
    }
}
