using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogSample.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        RelayCommand _OpenExamWindow;
        public RelayCommand OpenExamWindow
        {
            get { return _OpenExamWindow; }
        }

        public MainWindowViewModel()
        {
            _OpenExamWindow = new RelayCommand(OpenExamWindowExecute);
        }

        String _examDialogResult;
        public String ExamDialogResult
        {
            get { return _examDialogResult; }
            set
            {
                _examDialogResult = value;
                OnPropertyChanged("ExamDialogResult");
            }
        }

        public void OpenExamWindowExecute()
        {
            ExamWindowViewModel vm = new ExamWindowViewModel();
            bool result = DialogService.GetInstance().ShowModel(vm);
            if (result == true)
                ExamDialogResult = "OK";
            else
                ExamDialogResult = "Cancel";
        }
    }
}

