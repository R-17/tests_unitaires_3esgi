using LibrarieTestUnitaires;
using System;

namespace ConsoleAppTestsUnitaires
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Prenom");
            Console.WriteLine("==========================================");
            Console.WriteLine("Entrez un prénom de moins de 30 lettres : ");
            string unprenom = Console.ReadLine();

            Prenom unPrenom = new Prenom(unprenom);
            Console.WriteLine(unPrenom.HelloPrenom());
            Console.WriteLine("==========================================");
            Console.WriteLine("SWAPI");
            Console.WriteLine("==========================================");
            Swapi unSwapi = new Swapi();
            unSwapi.AvoirFilmsAvecLuke();
        }
    }
}
