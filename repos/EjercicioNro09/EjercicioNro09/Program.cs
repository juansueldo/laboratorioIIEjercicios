using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioNro09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";
            Console.WriteLine(MiClaseEstatica.Mensaje(10));
            Console.WriteLine("Dibuja una piramide de asteriscos\n" +
                              "---------------------------------");
            int i;
            int altura;
            int incremento = 0;

            Console.Write("Ingrese altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());
            while (incremento <= altura)
            {

                for (i = 0; i < incremento; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                incremento++;
            }
            Console.ReadLine();
        }
    }
}
