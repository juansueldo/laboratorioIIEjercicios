using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool auxiliar;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float auxiliarInt = 0;
            float promedio;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.Write("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    auxiliar = (Class1.Validar(numero, -100, 100));
                    if(auxiliar == false)
                    {
                        Console.Write("Error. ");
                    }
                    else
                    {
                        auxiliarInt += numero;
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        else if (numero > maximo)
                        {
                            maximo = numero;
                        }
                    }
                } while (auxiliar == false);     
                
            }
            promedio = auxiliarInt / 10;
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El maximo es {0}", maximo);
            Console.Write("El promedio es {0,3:#,###.00}", promedio);
            Console.ReadKey();
            

        }
    }
}
