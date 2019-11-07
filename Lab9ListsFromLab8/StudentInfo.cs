using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9ListsFromLab8
{
    class StudentInfo
    {
        public string name;// name;  //Name
        public string job; // job;    //HomeTown
        public string course;// course;   //FavoriteFood

        //default constructor
        public StudentInfo() { }

        //overloaded constructor
        public StudentInfo(string Name)
        {
            name = Name;
        }

        public StudentInfo(string Name, string Job)
        {
            name = Name;
            job = Job;
        }

        public StudentInfo(string Name, string Job, string Course)
        {
            name = Name;
            job = Job;
            course = Course;
        }
       

    }
}
