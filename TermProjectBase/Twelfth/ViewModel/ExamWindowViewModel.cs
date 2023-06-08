using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using Twelfth.Model;


namespace Twelfth.ViewModel
{

    class ExamWindowViewModel : ViewModelBase
    {
        ObservableCollection<Study> _studys;

        public ObservableCollection<Study> Studys
        {
            get
            {
                return _studys;
            }
        }

        public ExamWindowViewModel()
        {
            ExamListFromDB examListFromDB = new ExamListFromDB();

            _studys = examListFromDB.GetStudies();
        }
    }
}
