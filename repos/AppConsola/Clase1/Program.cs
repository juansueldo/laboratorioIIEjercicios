using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Vamo' lo Rayis";
            int a = 1;
            if(a < 10)
            {
                a += 5;
            }
            Console.WriteLine("Hola mundo! {0,3}",a);

            Console.ReadKey();
        }
    }
}
