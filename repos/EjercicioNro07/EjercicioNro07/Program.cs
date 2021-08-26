using System;

namespace EjercicioNro07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
            con DateTime.Now).
            Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/
            Console.Title = "Ejercicio 07";
            Console.WriteLine("Comprobar dias vividos\n" +
                              "--------------------------------");
            // Variables
            DateTime nacimiento;
            DateTime hoy;
            TimeSpan diferencia;

            // Nacimiento
            Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");
            nacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("La fecha de nacimiento es: {0}", nacimiento);

            // Hoy            
            hoy = DateTime.Now;
            Console.WriteLine("La fecha de hoy es: {0}", hoy);

            // Diferencia por pantalla
            diferencia = hoy - nacimiento;
            Console.WriteLine("Los dias de vida vividos son: {0}", diferencia.Days);
            Console.ReadLine();
        }
    }
}
