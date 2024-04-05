using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Malte";
            person.LastName = "Elwhagen";
            person.BirthDate = new DateTime(2006, 1, 18);

            Console.WriteLine($"Namn: {person.FullName}");
            Console.WriteLine($"Vuxen: {person.IsAdult}");
        }
    }
}