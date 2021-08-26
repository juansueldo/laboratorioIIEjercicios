using System;

namespace EjercicioNro3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya
             * hasta el número que ingrese el usuario por consola.
               Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).*/
            int numeroIngresado;
            string ingreso;

            Console.Write("Ingrese un numero: ");
            int.TryParse(ingreso = Console.ReadLine(), out numeroIngresado);
            Console.WriteLine("Los numeros primos son:");
            for (int i = 0; i < numeroIngresado; i++)
                {
                   if(i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            
        }
    }
}
