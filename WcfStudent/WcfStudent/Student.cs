using System.Collections.Generic;

namespace WcfStudent
{
    public class Student
    {
        private string _name;
        private string _klasseNavn;
        private int _studentNr;


        public Student()
        {
            
        }
        public Student(string name)
        {
            _name = name;
        }
        public Student(string name,string klasseNavn,int studentNr)
        {
            _name = name;
            _klasseNavn = klasseNavn;
            _studentNr = studentNr;

        }
        public int StudentNr
        {
            get { return _studentNr; }
            set { _studentNr = value; }
        }


        public string Klassenavn
        {
            get { return _klasseNavn; }
            set { _klasseNavn = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}