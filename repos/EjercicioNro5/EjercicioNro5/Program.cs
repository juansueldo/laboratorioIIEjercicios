using System;

namespace EjercicioNro5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensaje
            Console.Title = "Ejercicio 05";
            Console.WriteLine("Calculo centro numerico\n" +
                              "-----------------------");
            // Variables
            double contador = 1;
            double numero;
            double i;
            double j;
            double sumaAtras;
            double sumaAdelante;

            // Ingreso de datos
            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());

            // Comienzo del programa
            while (contador < numero)
            {
                contador++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (i = 1; i < contador; i++)
                {
                    sumaAtras += i;
                }
                //calculo para adelante
                for (j = contador + 1; j <= sumaAtras; j++)
                {
                    
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    { 
                        break; 
                    }
                      
                    sumaAdelante += j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                {
                    Console.WriteLine("Es centro numerico: {0}", contador);
                }
                    
            }
            Console.ReadLine();
        }
    }
}
