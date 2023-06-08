using System;
using System.Collections.Generic;
using System.Text;
using Twelfth.ViewModel;
using System.Windows;

namespace Twelfth
{
    class DialogService
    {
        Dictionary<Type, Type> ViewModelMap = new Dictionary<Type, Type>();

        private static DialogService _instance;

        private DialogService()
        {
            ViewModelMap.Add(typeof(MainWindowViewModel), typeof(MainWindow));
            ViewModelMap.Add(typeof(ExamWindowViewModel), typeof(ExamWindow));
        }

        public static DialogService GetInstance()
        {
            if (_instance == null)
                _instance = new DialogService();

            return _instance;
        }

        public bool ShowModel(ViewModelBase vm)
        {
            Type window;

            ViewModelMap.TryGetValue(vm.GetType(), out window);

            Window win = Activator.CreateInstance(window) as Window;

            win.DataContext = vm;
            return win.ShowDialog() ?? false;
        }
    }
}
