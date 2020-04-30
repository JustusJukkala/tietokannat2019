using System;
using System.Linq;
using PersonDBExample.Data;
namespace PersonDBExample
{
    class Program
    {
        static private readonly PersonexampledbContext context = new PersonexampledbContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Tulosta kaikki henkilöt");
            PrintAll();
        }

        static void PrintAll()
        {
            var persons = context.Person.ToList();

            foreach (var p in persons)
            {
                Console.WriteLine($"Etunimi: {p.FirstName} Kaupunki: {p.City}");
            }
        }

    }
}
