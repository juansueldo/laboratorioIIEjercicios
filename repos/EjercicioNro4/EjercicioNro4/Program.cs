using System;

namespace EjercicioNro4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea
             * mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
             * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/
            int numero;
            int cuadrado = 2;
            int cubo = 3;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numero);
            } while (numero <= 0);
            Console.Write("El numero {0} al cuadrado es: ", numero);
            Console.WriteLine(Math.Pow(numero, cuadrado));
            Console.Write("El numero {0} al cubo es: ", numero);
            Console.WriteLine(Math.Pow(numero, cubo));
           
        }
    }
}
