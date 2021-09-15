using System;
using Billetes;

namespace EjercicioNro20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de monedas";
            double fahrenheit;
            double kelvin;
            double celsius;

            Console.Write("Ingrese la cantidad de fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de kelvin: ");
            kelvin = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de celsius: ");
            celsius = double.Parse(Console.ReadLine());

            Fahrenheit f = new Fahrenheit(fahrenheit);
            Kelvin k = new Kelvin(kelvin);
            Celsius c = new Celsius(celsius);

            Kelvin aux_k = k + f;
            Celsius aux_c = c + f;
            Fahrenheit aux_f = f + c;

            Console.WriteLine("Kelvin + Fahrenheit : {0}", aux_k.GetTemperatura());

            Console.WriteLine("Celsius + Fahrenheit: {0}", aux_c.GetTemperatura());

            Console.WriteLine("Fahrenheit + Celsius: {0}", aux_f.GetTemperatura());

            Console.ReadKey();
        }
    }
}
