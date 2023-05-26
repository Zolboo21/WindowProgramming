using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using week13.ViewModel;

namespace week13
{
    internal class Dilog
    {
        Dictionary<Type,Type> ViewModelMap= new Dictionary<Type,Type>();
        private static Dilog _instance;

        private Dilog() { 
         ViewModelMap.Add(typeof(MainWindowViewModel),typeof(MainWindow));
        ViewModelMap.Add(typeof(ExamWindowViewModel),typeof(ExamWindow));

        }

        public static Dilog GetInstance()
        {
            if(_instance == null)   
                _instance = new Dilog();
            return _instance;
        }

        public bool ShowModel(ViewModelBase vm) 
        {

            Type window;

            ViewModelMap.TryGetValue(vm.GetType(), out window);

            Window win = Activator.CreateInstance(window) as Window;
            win.DataContext= vm;
            return win.ShowDialog() ?? false;

        }




    }
}
