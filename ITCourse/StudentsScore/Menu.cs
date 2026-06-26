using ITCourse.StudentsScore;
using System;

namespace StudentScores
{
    public class Menu
    {
        private StudentService service;

        public Menu()
        {
            service = new StudentService();
        }

        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Find Student");
                Console.WriteLine("3. Update Score");
                Console.WriteLine("4. Show All Students");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        AddStudentMenu();
                        break;

                    case 2:
                        FindStudentMenu();
                        break;

                    case 3:
                        UpdateStudentMenu();
                        break;

                    case 4:
                        service.ShowAllStudents();
                        break;

                    case 5:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void AddStudentMenu()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Score: ");
            int score = int.Parse(Console.ReadLine());

            service.AddStudent(name, score);
        }

        private void FindStudentMenu()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            service.FindStudent(name);
        }

        private void UpdateStudentMenu()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("New score: ");
            int score = int.Parse(Console.ReadLine());

            service.UpdateScore(name, score);
        }
    }
}