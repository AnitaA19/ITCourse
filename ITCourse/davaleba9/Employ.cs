using System;
using System.Collections.Generic;
using System.Text;

namespace ITCourse.davaleba9
{
    internal class Employ
    {
        public Country Country { get; set; }
        public Gender Gender { get; set; }
        public Contacts Contacts { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employ(string name, string surname, DateTime dateOfBirth, Country country, Gender gender, Contacts contacts)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Country = country;
            Gender = gender;
            Contacts = contacts;
        }


        public int calculateAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now < DateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }

        public static void PrintByCountry(Employ[] employs, Country country)
        {
            foreach (Employ employ in employs)
            {
                if (employ.Country == country)
                {
                    Console.WriteLine($"{employ.Name} {employ.Surname}");
                }
            }
        }

    }
}
