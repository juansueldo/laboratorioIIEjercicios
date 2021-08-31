using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            int altura, f;

            Console.WriteLine("Ingrese un numero entero positivo:");
            altura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                Console.Write(" ");
                for (f = 0; f < altura - i; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}