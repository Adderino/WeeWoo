using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeWoo
{
    class Program
    {
        static List<Pet> pets = new List<Pet>();
        private static readonly Random getrandom = new Random();
        static void Main(string[] args)
        {

            pets.Add(new Cat("OMEGALUL"));
            pets.Add(new Dog("OMEGALULU"));
            pets.Add(new Bird("OMEGALULUL"));
            pets.Add(new Fish("OMEGALU"));

            Console.WriteLine(@"Thou who has entered this very port shall choose your pet...
            Now go forth choose your pet
            Press any key to go forth or press esc to escape back into the abyss");


            ConsoleKey ck = Console.ReadKey().Key;
            while (ck != ConsoleKey.Escape)
            {
                int n = getrandom.Next(0, pets.Count);
                Console.WriteLine("\nYour pet is... ");
                Console.WriteLine(pets[n]);
                Console.WriteLine("");
                ck = Console.ReadKey().Key;
            }   
        }
    }
}
