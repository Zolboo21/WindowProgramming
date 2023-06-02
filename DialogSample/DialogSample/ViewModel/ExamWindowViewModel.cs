using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogSample.ViewModel
{
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

        private int _numImages;
        public int NumImages
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
            _studys = new ObservableCollection<Study>();
            _studys.Add(new Study() { PatientID = "A6475839", PatientName = "Risa candle", Sex = "F", AccessionNumber="34321234", StudyDate = "20230517", StudyTime = "144927", NumImages = 3, Description = "vascular" } );
            _studys.Add(new Study() { PatientID = "A9983457", PatientName = "KIM HO YOUNG", Sex = "M", AccessionNumber="93842", StudyDate = "20231216", StudyTime = "093439", NumImages = 9, Description = "River Convex" } );
            _studys.Add(new Study() { PatientID = "A8374621", PatientName = "Rola", Sex = "F", AccessionNumber = "938472", StudyDate = "20230105", StudyTime = "160505", NumImages = 7, Description = "River Convex" });
            _studys.Add(new Study() { PatientID = "A9283746", PatientName = "Hong GIl Dong", Sex = "M", AccessionNumber = "", StudyDate = "20220523", StudyTime = "124127", NumImages = 5, Description = "OB 1st" });
            _studys.Add(new Study() { PatientID = "A9983457", PatientName = "KIM HO YOUNG", Sex = "M", AccessionNumber = "436573", StudyDate = "20210808", StudyTime = "183045", NumImages = 11, Description = "Cardiac Stress Echo" });
        }
    }
}
