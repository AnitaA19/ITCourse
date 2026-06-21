using ITCourse.StudentsProject.Models;
using ITCourse.StudentsProject.Services;
using ITCourse.StudentsProject.Utilities;
using System;

namespace ITCourse.StudentsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Logger logger = new Logger("Students Project"))
            {
                Student[] students = new Student[20];

                students[0] = new Student("Nika", "Beridze", 20, "nika@gmail.com", "+995555111111", 3.9, Faculty.IT);
                students[1] = new Student("Ana", "Abuladze", 19, "ana@gmail.com", "+995555222222", 3.7, Faculty.Business);
                students[2] = new Student("Luka", "Kapanadze", 21, "luka@gmail.com", "+995555333333", 3.5, Faculty.Design);
                students[3] = new Student("Mariam", "Gelashvili", 22, "mariam@gmail.com", "+995555444444", 4.0, Faculty.Medicine);
                students[4] = new Student("Saba", "Abashidze", 18, "saba@gmail.com", "+995555555555", 3.8, Faculty.IT);
                students[5] = new Student("Nino", "Tsereteli", 19, "nino@gmail.com", "+995555666666", 3.6, Faculty.Business);
                students[6] = new Student("Dato", "Mikadze", 23, "dato@gmail.com", "+995555777777", 3.2, Faculty.Design);
                students[7] = new Student("Elene", "Machavariani", 20, "elene@gmail.com", "+995555888888", 3.9, Faculty.Medicine);
                students[8] = new Student("Giorgi", "Khutsishvili", 21, "giorgi@gmail.com", "+995555999999", 3.4, Faculty.Business);
                students[9] = new Student("Anita", "Balasanyan", 22, "anita@gmail.com", "+995555000000", 4.0, Faculty.IT);

                StudentManager manager = new StudentManager(students, 10);

                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\nMENU");
                    Console.WriteLine("1. Show all Students");
                    Console.WriteLine("2. Find the best student");
                    Console.WriteLine("3. Calculate average GPA");
                    Console.WriteLine("4. Find the student by last name");
                    Console.WriteLine("5. Sort the students by GPA");
                    Console.WriteLine("6. Add the new student");
                    Console.WriteLine("7. Delete the student");
                    Console.WriteLine("8. Exit");

                    Console.Write("Choose operation: ");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Wrong choice.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            manager.ShowAllStudents();
                            break;

                        case 2:
                            Student best = manager.FindBestStudent();

                            Console.WriteLine("\nThe best student:");
                            Console.WriteLine(best.GetInfo());
                            break;

                        case 3:
                            Console.WriteLine($"\nAverage GPA: {manager.GetAverageGPA():F2}");
                            break;

                        case 4:
                            Console.Write("Enter the last name: ");
                            string lastName = Console.ReadLine();

                            Student found = manager.FindStudentByLastName(lastName);

                            if (found != null)
                            {
                                Console.WriteLine("\nStudent found:");
                                Console.WriteLine(found.GetInfo());
                            }
                            else
                            {
                                Console.WriteLine("\nStudent was not found.");
                            }

                            break;

                        case 5:
                            manager.SortByGPA();

                            Console.WriteLine("\nStudents were sorted:\n");
                            manager.ShowAllStudents();
                            break;

                        case 6:
                            try
                            {
                                Console.Write("Name: ");
                                string name = Console.ReadLine();

                                Console.Write("Last Name: ");
                                string lname = Console.ReadLine();

                                Console.Write("Age: ");
                                byte age = byte.Parse(Console.ReadLine());

                                Console.Write("Email: ");
                                string email = Console.ReadLine();

                                Console.Write("Phone: ");
                                string phone = Console.ReadLine();

                                Console.Write("GPA: ");
                                double gpa = double.Parse(Console.ReadLine());

                                Console.WriteLine("0 - IT");
                                Console.WriteLine("1 - Business");
                                Console.WriteLine("2 - Design");
                                Console.WriteLine("3 - Medicine");

                                Faculty faculty =
                                    (Faculty)int.Parse(Console.ReadLine());

                                Student newStudent = new Student(
                                    name,
                                    lname,
                                    age,
                                    email,
                                    phone,
                                    gpa,
                                    faculty);

                                manager.AddStudent(newStudent);

                                Console.WriteLine("\nStudent was added.\n");
                                manager.ShowAllStudents();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;

                        case 7:
                            Console.Write("Enter email: ");
                            string studentEmail = Console.ReadLine();

                            manager.RemoveStudent(studentEmail);

                            Console.WriteLine("\nCurrent students:\n");
                            manager.ShowAllStudents();

                            break;

                        case 8:
                            exit = true;
                            Console.WriteLine("Program ended.");
                            break;

                        default:
                            Console.WriteLine("Wrong choice.");
                            break;
                    }
                }
            }
        }
    }
}