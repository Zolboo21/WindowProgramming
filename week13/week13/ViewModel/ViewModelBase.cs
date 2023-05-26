using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13.ViewModel
{
    internal class ViewModelBase : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;
    }
}
