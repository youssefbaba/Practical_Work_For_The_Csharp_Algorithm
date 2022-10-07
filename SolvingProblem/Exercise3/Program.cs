namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"First Name : {person.FirstName}");
            Console.WriteLine($"Last Name : {person.LastName}");
            Console.WriteLine($"Age : {person.Age}");
            Console.WriteLine($"Mobile : {person.Mobile}");
            Console.WriteLine($"Origin : {person.Origin}");

            Console.WriteLine("#################################");

            Person person1 = new Person("Baba", 25, "648578564", Person.Cities.Rabat);
            Console.WriteLine($"First Name : {person1.FirstName}");
            Console.WriteLine($"Last Name : {person1.LastName}");
            Console.WriteLine($"Age : {person1.Age}");
            Console.WriteLine($"Mobile : {person1.Mobile}");
            Console.WriteLine($"Origin : {person1.Origin}");

            Console.WriteLine("#################################");

            Person person2 = new Person("Baba", 29, "648488561", Person.Cities.CasaBlanca, "Hassna");
            Console.WriteLine($"First Name : {person2.FirstName}");
            Console.WriteLine($"Last Name : {person2.LastName}");
            Console.WriteLine($"Age : {person2.Age}");
            Console.WriteLine($"Mobile : {person2.Mobile}");
            Console.WriteLine($"Origin : {person2.Origin}");

            Console.WriteLine("#################################");

            Person person3 = new Person(person2);
            Console.WriteLine($"First Name : {person3.FirstName}");
            Console.WriteLine($"Last Name : {person3.LastName}");
            Console.WriteLine($"Age : {person3.Age}");
            Console.WriteLine($"Mobile : {person3.Mobile}");
            Console.WriteLine($"Origin : {person3.Origin}");

            Person.ChangeAge(ref person3.Age);
            Console.WriteLine($"The new age of person = {person3.Age}");
            person3.KnowOrigin();

        }
    }
}