using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Text;

namespace Twelfth.Model
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


    class ExamListFromDB
    {
        SQLiteConnection _connection = new SQLiteConnection();

        public ObservableCollection<Study> GetStudies()
        {
            ObservableCollection<Study> examList = new ObservableCollection<Study>();

            _connection.ConnectionString = "Data Source=Ultrasound.db;foreign keys=true;";
            _connection.Open();

            string sql = "Select * from Study;";

            SQLiteCommand cmd = new SQLiteCommand(sql, _connection);
            SQLiteDataReader sqliteDataReader = cmd.ExecuteReader();

            while (sqliteDataReader.Read())
            {
                Study study = new Study();
                study.StudyDate = (string)sqliteDataReader["StudyDate"];
                study.StudyTime = (string)sqliteDataReader["StudyTime"];
                study.AccessionNumber = (string)sqliteDataReader["AccessionNumber"];
                study.Description = (string)sqliteDataReader["StudyDescription"];

                sql = "Select * from Patient where IndexPatient = " + ((long)sqliteDataReader["IndexPatient"]).ToString() + ";";

                SQLiteCommand cmdPatient = new SQLiteCommand(sql, _connection);
                SQLiteDataReader sqlitePatientReader = cmdPatient.ExecuteReader();

                sqlitePatientReader.Read();

                study.PatientID = (string)sqlitePatientReader["PatientID"];
                study.PatientName = (string)sqlitePatientReader["Name"];
                study.Sex = (string)sqlitePatientReader["Sex"];

                sqlitePatientReader.Close();

                sql = "Select * from Image where IndexStudy = " + ((long)sqliteDataReader["IndexStudy"]).ToString() + ";";

                SQLiteCommand cmdImages = new SQLiteCommand(sql, _connection);
                SQLiteDataReader sqliteImagesReader = cmdImages.ExecuteReader();
                int imageCount = 0;
                while(sqliteImagesReader.Read())
                    imageCount++;

                study.NumImages = imageCount;

                sqliteImagesReader.Close();

                examList.Add(study);
            }

            sqliteDataReader.Close();

            _connection.Close();
            return examList;
        }
    }
}
