using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {
        // Enumeration
        public enum Cities
        {
            Safi,           // Default value = 0
            Marrakech,      // Default value = 1
            Rabat,          // Default value = 2
            Tanger,         // Default value = 3
            CasaBlanca,     // Default value = 4
        }
        // Fields 
        private string _firstName;
        private string _lastName;
        public int Age;
        public string Mobile;
        public Cities Origin;
        public static int Counter = 0;
        public static bool Check = false;

        // Constructors
        public Person()
        {
            Console.WriteLine($"Constructing the Person class .");
            if (!Check)
            {
                StartProgram();
            }
        }
        public Person(string lastName, int age, string mobile, Cities origin, string firstName = "Youssef") : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Mobile = mobile;
            Origin = origin;
            if (!Check)
            {
                StartProgram();
            }
        }
        public Person(Person p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            Age = p.Age;
            Mobile = p.Mobile;
            Origin = p.Origin;
        }

        // Properties 
        public string FirstName
        {
            init
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }
        public static void ChangeAge(ref int oldAge)
        {
            Console.Write($"Please enter your new age : ");
            int newAge;
            if (int.TryParse(Console.ReadLine(), out newAge))
            {
                oldAge = newAge;
            }
            else
            {
                throw new Exception($"Conversion from string to int failed !");
            }
        }
        public void KnowOrigin()
        {
            switch (Origin)
            {
                case Cities.Safi:
                    Console.WriteLine($"This person is originally from {Cities.Safi}");
                    break;
                case Cities.Marrakech:
                    Console.WriteLine($"This person is originally from {Cities.Marrakech}");
                    break;
                case Cities.Rabat:
                    Console.WriteLine($"This person is originally from {Cities.Rabat}");
                    break;
                case Cities.Tanger:
                    Console.WriteLine($"This person is originally from {Cities.Tanger}");
                    break;
                case Cities.CasaBlanca:
                    Console.WriteLine($"This person is originally from {Cities.CasaBlanca}");
                    break;
                default:
                    Console.WriteLine($"Invalid Data !");
                    break;
            }
        }
        public void StartProgram()
        {
            if ((this != null) && (Counter < 1))
            {
                Console.WriteLine($"The program starts ...");
                Counter = 1;
                Check = true;
            }
        }
    }
}
