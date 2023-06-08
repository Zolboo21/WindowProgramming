using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Drawing;
using Twelfth.Model;
using CommunityToolkit.Mvvm.Input;

namespace Twelfth.ViewModel
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

        ExamWindowViewModel _vm = new ExamWindowViewModel();

        public void OpenExamWindowExecute()
        {
            bool result = DialogService.GetInstance().ShowModel(_vm);
            if (result == true)
            {
            }
        }
    }
}
