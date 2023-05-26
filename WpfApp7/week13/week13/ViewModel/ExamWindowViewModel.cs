using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13.ViewModel
{
    class ExamWindowViewModel:ViewModelBase
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
            _studys = new ObservableCollection<Study>();

            _studys.Add(new Study() { PatientID = "000321", PatientName = "Hong il dong", Sex = "Male", AccessionNumber="ab012", StudyDate="104", Description="cardio", NumImages="10", StudyTime="10" });
            _studys.Add(new Study() { PatientID = "321321", PatientName = "Kim  James", Sex = "Male" });

        }

    }
    
    class Study
    {
        private String _patientID;
        public String PatientID
        {
            get { return _patientID; }
            set
            {
                _patientID = value;
            }
        }

        private String _patientName;
        public String PatientName
        {
            get { return _patientName; }
            set
            {
                _patientName = value;
            }
        }

        private String _sex;
        public String Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
            }
        }

        private String _accessionNumber;
        public String AccessionNumber
        {
            get { return _accessionNumber; }
            set
            {
                _accessionNumber = value;
            }
        }

        private String _studyDate;
        public String StudyDate
        {
            get { return _studyDate; }
            set
            {
                _studyDate = value;
            }
        }

        private String _studyTime;
        public String StudyTime
        {
            get { return _studyTime; }
            set
            {
                _studyTime = value;
            }
        }

        private String _numImages;
        public String NumImages
        {
            get { return _numImages; }
            set
            {
                _numImages = value;
            }
        }

        private String _description;
        public String Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

    }
    
}
