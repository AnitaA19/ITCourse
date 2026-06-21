using ITCourse.StudentsProject.Interfaces;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ITCourse.StudentsProject.Models
{
    public class Student : Person, Iprintable
    {
        private double _gpa { get; set; }
        private Faculty Faculty { get; set; }

        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0.0 || value > 4.0)
                    throw new ArgumentOutOfRangeException(nameof(GPA), "GPA must be between 0.0 and 4.0");
                _gpa = value;
            }
        }



        public Student(string name, string lastName, byte age, string email, string phone, double gpa, Faculty faculty)
            : base(name, lastName, age, email, phone)
        {
            GPA = gpa;
            Faculty = faculty;
        }

        public override string GetInfo()
        {
            return $"{Name} {LastName} | ასაკი: {Age} | ფაკულტეტი: {Faculty} | GPA: {GPA:F1} | Email: {Email} | ტელ: {Phone}";
        }

        public void Print()
        {
            Console.WriteLine($"│  სახელი:      {Name} {LastName,-20}│");
            Console.WriteLine($"│  ასაკი:        {Age,-29}│");
            Console.WriteLine($"│  ფაკულტეტი:   {Faculty,-29}│");
            Console.WriteLine($"│  GPA:          {GPA,-29:F1}│");
            Console.WriteLine($"│  Email:        {Email,-29}│");
            Console.WriteLine($"│  ტელეფონი:    {Phone,-29}│");
        }

        public static bool operator >(Student a, Student b) => a.GPA > b.GPA;
        public static bool operator <(Student a, Student b) => a.GPA < b.GPA;
        public static bool operator >=(Student a, Student b) => a.GPA >= b.GPA;
        public static bool operator <=(Student a, Student b) => a.GPA <= b.GPA;
    }
}

