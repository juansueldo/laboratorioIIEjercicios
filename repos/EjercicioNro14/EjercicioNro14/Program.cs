using System;

namespace EjercicioNro14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double cuadrado;
            double trianguloBase;
            double trianguloAltura;
            double circulo;
            double area;
            do
            {
                Console.WriteLine("Que desea realizar?:" + "\n" +
                                "1. Calcular el area de un cuadrado." + "\n" +
                                "2. Cacular el area de un triangulo." + "\n" +
                                "3. Calular el area de un circulo." + "\n" +
                                "4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un lado: ");
                        cuadrado = double.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCuadrado(cuadrado);
                        Console.WriteLine("El area del cuadrado es: {0,0:#,###.00}", area);
                        break;
                    case 2:
                        Console.Write("Ingrese un la base: ");
                        trianguloBase = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese un la altura: ");
                        trianguloAltura = double.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularTriangulo(trianguloBase, trianguloAltura);
                        Console.WriteLine("El area del cuadrado es: {0,0:#,###.00}", area);
                        break;
                    case 3:
                        Console.Write("Ingrese el radio: ");
                        circulo = double.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCirculo(circulo);
                        Console.WriteLine("El area del cuadrado es: {0,0:#,###.00}", area);
                        break;
                }
            } while (opcion != 4);

        }
        
    }
}


