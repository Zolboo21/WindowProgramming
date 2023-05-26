using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {


        RelayCommand _OpenExamWindow;
        public RelayCommand OpenExamWindow
        {
            get
            {
                return _OpenExamWindow;
            }
        }
        public MainWindowViewModel()
        {
            _OpenExamWindow = new RelayCommand(OpenExamWindowExcute);
        }

        public void OpenExamWindowExcute()
        {
            
        }
    }
    
    }

