using System;
using Billetes;

namespace EjercicioNro20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de monedas";
            double dolar;
            double pesos;
            double euros;

            Console.Write("Ingrese la cantidad de dolares: ");
            dolar = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de pesos: ");
            pesos = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de euros: ");
            euros = double.Parse(Console.ReadLine());

            Dolar d = new Dolar(dolar);
            Pesos p = new Pesos(pesos);
            Euro e = new Euro(euros);

            Pesos aux = p + d;
            Euro aux_e = e + d;
            Dolar aux_d = d + p;

            Console.WriteLine("Euro + Dolar : {0:C2}", aux_e.GetCantidad());
       
            Console.WriteLine("Pesos + Dólar: {0:C2}", aux.GetCantidad());

            Console.WriteLine("Dolar + Pesos: {0:C2}", aux_d.GetCantidad());

            Console.ReadKey();
        }
    }
}
