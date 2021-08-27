using System;

namespace EjercicioNro12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int i = 0;
            int numero;
            char respuesta;
                do
                {
                    Console.WriteLine("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Desea continuar? [s] o [n]");
                    respuesta =  char.Parse(Console.ReadLine());
                    i+=numero;
                    Console.WriteLine("La suma es {0}", i);
                    
                } while (ValidarRespuesta.ValidaS_N(respuesta) == true);
            Console.WriteLine("La suma de los nros ingresados es {0}", i);
            Console.ReadKey();
        }
       
    }
}
