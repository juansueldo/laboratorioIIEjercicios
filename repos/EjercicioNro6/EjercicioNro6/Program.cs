using System;

namespace EjercicioNro6
{
    class Program
    {
        static void Main(string[] args)
        { /*Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
            también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
            //Titulo y cabecera

            Console.Title = "Ejercicio 06";
            Console.WriteLine("Calculo año bisiesto\n" +
                              "-----------------------");
            //Variables

            int inicio;
            int fin;
            int bisiesto = 4;

            //Mensaje y captura de datos
            Console.Write("Ingrese el año de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año de finalizar: ");
            fin = int.Parse(Console.ReadLine());

            //Programa

            for(int i = inicio; i <= fin; i++)
            {
                if ((i % bisiesto == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("Los años bisiestos son: {0}", i);
                }
            }
        }
    }
}
