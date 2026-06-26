using System.Collections.Generic;

namespace ITCourse.StudentsScore
{
    internal class StudentService
    {
        private List<string> _studentNames;
        private Dictionary<string, int> _studentScores;

        public StudentService()
        {
            _studentNames = new List<string>();
            _studentScores = new Dictionary<string, int>();
        }

        public void AddStudent(string name, int score)
        {
            if (_studentScores.ContainsKey(name))
            {
                Console.WriteLine("Student already exists.");
                return;
            }
            _studentNames.Add(name);
            _studentScores.Add(name, score);

            Console.WriteLine("Student added successfully.");
        }

        public void FindStudent(string name)
        {
            if (_studentScores.ContainsKey(name))
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Score: {_studentScores[name]}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }


        public void UpdateScore(string name, int newScore)
        {
            if (_studentScores.ContainsKey(name))
            {
                _studentScores[name] = newScore;
                Console.WriteLine("Score updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void ShowAllStudents()
        {
            if (_studentNames.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (string name in _studentNames)
            {
                Console.WriteLine($"{name} - {_studentScores[name]}");
            }
        }

    }
}