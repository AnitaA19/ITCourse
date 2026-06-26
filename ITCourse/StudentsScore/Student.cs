using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.StudentsScore
{
    internal class Student
    {
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; set; }
        public int Score { get; set; }


    }
}
