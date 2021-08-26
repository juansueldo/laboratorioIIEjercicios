using System;

namespace EjercicioNro1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 5;
            string ingreso;
            int minimo = int.MaxValue;
            int maximo =  int.MinValue;
            int numeroIngresado;
            float auxiliar = 0;
            float promedio;
            for (int i = 0; i < totalNumeros; i++)
            {
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();
                if(int.TryParse(ingreso, out numeroIngresado))
                {
                    auxiliar += numeroIngresado;
                    if (numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }
                    else if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                }
            }
            promedio = auxiliar / totalNumeros;
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El maximo es {0}", maximo);
            Console.Write("El promedio es {0,3:#,###.00}", promedio);
        }
    }
}
