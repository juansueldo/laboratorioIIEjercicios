using System;

namespace EjercicioNro15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";
            double numero1, numero2,resultado;
            char operacion;

            Console.Write("Ingrese el primer numero: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la operacion a realizar[+, -, *, /]: ");
            operacion = char.Parse(Console.ReadLine());

           resultado = Calculadora.Calcular(numero1, numero2, operacion);
           Console.Write("El resultado es {0:#,##.00}",resultado);
           Console.ReadKey();

        }
    }
}
