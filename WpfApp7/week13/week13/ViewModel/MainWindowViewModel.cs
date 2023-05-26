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
        String _examDialogResult;
        public String ExamDialogResult
        {
            get { return _examDialogResult; }
            set { _examDialogResult = value;
                OnPropertyChanged("ExamDialogResult");
            }
        }

     

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
            ExamWindowViewModel vm= new ExamWindowViewModel();
            bool result = Dilog.GetInstance().ShowModel(vm);
            if (result==true) {
                ExamDialogResult = "ok";

            }
            else
            { ExamDialogResult = "Cancel"; }
            
        }
    }
    
    }

