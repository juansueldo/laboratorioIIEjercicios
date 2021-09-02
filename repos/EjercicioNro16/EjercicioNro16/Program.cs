using System;
using Entidades;

namespace EjercicioNro16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";
            // INSTANCIAMOS ALUMNOS
            Alumno alum1 = new Alumno("Juan", "Sueldo", 11101);
            Alumno alum2 = new Alumno("Natalia", "Fernandez", 11102);
            Alumno alum3 = new Alumno("Emilia", "Sueldo", 11103);

            //SETEAMOS NOTAS
            alum1.Estudiar(4, 2);
            alum2.Estudiar(8, 9);
            alum3.Estudiar(7, 8);

            //CALCULA NOTA FINAL
            alum1.CalcularFinal();
            alum2.CalcularFinal();
            alum3.CalcularFinal();

            //MOSTRAMOS DATOS DE LOS ALUMNOS
            Console.WriteLine(alum1.Mostrar());
            Console.WriteLine(alum2.Mostrar());
            Console.WriteLine(alum3.Mostrar());
            Console.ReadKey();
        }
    }
}
