using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeWoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet p = new Pet();

            Console.Write("Name your pet: ");
            p.Name = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
