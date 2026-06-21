using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ITCourse.StudentsProject.Models
{
    public abstract class Person
    {
        private string _name;
        private string _lastName;
        private byte _age;
        private string _email;
        private string _phone;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                _lastName = value;
            }
        }

        public byte Age
        {
            get { return _age; }
            set
            {
                if (value < 16 || value > 100)
                    throw new ArgumentException("Age must be between 16 and 100.");
                _age = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Email is not valid.");
                _email = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Phone cannot be empty.");
                if (!Regex.IsMatch(value, @"^\+?[0-9\s\-]{7,15}$"))
                    throw new ArgumentException("Phone number is not valid.");
                _phone = value;
            }
        }

        protected Person(string name, string lastName, byte age, string email, string phone)
        {
            _name = name;
            _lastName = lastName;
            _age = age;
            _email = email;
            _phone = phone;
        }

        public abstract string GetInfo();
    }
}
