using ITCourse.StudentsProject.Models;
using ITCourse.StudentsProject.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.StudentsProject.Services
{
    internal class StudentManager
    {
        private Student[] students;
        private int count;

        public StudentManager(Student[] students, int count)
        {
            this.students = students;
            this.count = count;
        }

        public void ShowAllStudents()
        {
            foreach (Student student in students)
            {
                if (student != null)
                {
                    Console.WriteLine(student.GetInfo());
                }
            }
        }

        public Student FindBestStudent()
        {

            Student best = students[0];

            for (int i = 1; i < count; i++)
            {
                if (students[i] > best)
                {
                    best = students[i];
                }
            }

            return best;
        }


        public double GetAverageGPA()
        {
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += students[i].GPA;
            }

            return sum / count;
        }

        public Student FindStudentByLastName(string lastName)
        {
            lastName = lastName.Trim().ToLower();

            for (int i = 0; i < count; i++)
            {
                if (students[i].LastName.ToLower().Contains(lastName))
                {
                    return students[i];
                }
            }
            Console.WriteLine("Student was not found");
            return null;
        }

        public void SortByGPA()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (students[j] < students[j + 1])
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        public void AddStudent(Student student)
        {
            if (count == students.Length)
            {
                Student[] temp = new Student[students.Length * 2];

                for (int i = 0; i < students.Length; i++)
                {
                    temp[i] = students[i];
                }

                students = temp;
            }

            students[count] = student;
            count++;
        }


        public void RemoveStudent(string email)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (students[i].Email.ToLower() == email.Trim().ToLower())
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                students[i] = students[i + 1];
            }

            students[count - 1] = null;
            count--;

            Console.WriteLine("Student removed successfully.");
        }
    }

}
