using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;



namespace final2.ViewModel
{
    class Work : ViewModelBase
    {
        String _company;
        public String Company
        {
            get { return _company; }
            set
            {
                _company = value;
                OnPropertyChanged("Company");
            }
        }
    }
    class MainWindowViewModel : ViewModelBase
    {
        ObservableCollection<Work> _works;

        public ObservableCollection<Work> Works
        {
            get
            {
                return _works;
            }
        }

        private void ModifyWorkExecute()
        {
            
        }

        public MainWindowViewModel()
        {
        _works = new ObservableCollection<Work>();

        _works.Add(new Work() { Company="aadas"});

        }
    }
}
