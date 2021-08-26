using System;

namespace EjercicioNro08
{
    class Program
    {
        struct Empleado
        {
            public string nombre;
            public float valorHora;
            public float anosAntiguedad;
            public float horasPorMes;
            public float totalHotas,
                totalAntiguedad, totalBruto,
                totalDescuento, totalNeto;
         }
        static void Main(string[] args)
        {
            // Variables
            int len = 100;
            Empleado[] empleados = new Empleado[len];
                
            bool respuesta;
            int contador = 1;
            char ingreso;
            // Mensajes
            Console.Title = "Ejercicio 08";
            Console.WriteLine("Cálculo de sueldo\n" +
                              "-----------------");

            // Ingreso de datos
            do
            {
                for (int i = 0; i < len; i++)
                {
                    Console.Write("Ingrese el valor de la hora del empleado: ");
                    empleados[i].valorHora = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese nombre del empleado: ");
                    empleados[i].nombre = Console.ReadLine();
                    Console.Write("Ingrese antiguedad: ");
                    empleados[i].anosAntiguedad = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
                    empleados[i].horasPorMes = float.Parse(Console.ReadLine());

                    empleados[i].totalHotas = empleados[i].valorHora * empleados[i].horasPorMes;
                    empleados[i].totalAntiguedad = empleados[i].anosAntiguedad * 30;
                    empleados[i].totalBruto = empleados[i].totalHotas + empleados[i].totalAntiguedad;
                    empleados[i].totalDescuento = (float)(empleados[i].totalBruto * 1.13) - empleados[i].totalBruto;
                    empleados[i].totalNeto = empleados[i].totalBruto - empleados[i].totalDescuento;

                    Console.Write("Desea ingresar otro empleado?: ");
                    ingreso = char.Parse(Console.ReadLine());

                    if (ingreso == 's')
                    {

                        respuesta = true;
                        Console.Write("{0}", respuesta);
                    }
                    else
                    {

                        respuesta = false;
                        Console.Write("{0}", respuesta);
                    }
                }
                } while (respuesta == true) ;
            
            

            //Mostrar en pantalla

            Console.Clear();
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "             Nombre: " + empleados[i].nombre + "\n" +
                            "         Antiguedad: " + empleados[i].anosAntiguedad + "\n" +
                            "     Valor por hora: " + empleados[i].valorHora + "\n" +
                            " Total sueldo bruto: " + empleados[i].totalBruto + "\n" +
                            "         Descuentos: " + empleados[i].totalDescuento + "\n" +
                            "Valor neto a cobrar: " + empleados[i].totalNeto + "\n");

            }
                
            Console.ReadLine();
        }
        }
}
