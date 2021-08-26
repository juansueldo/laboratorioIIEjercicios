using System;

namespace EjercicioNro08
{
    class Program
    {
        struct Empleado
        {
            public string nombre;
            public float valorHora;
            public float antiguedad,
                horasPorMes, totalHoras,
                totalAntiguedad, totalBruto,
                totalDescuento, totalNeto;
        }
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";
            Console.WriteLine("Cálculo de sueldo\n" +
                              "-----------------");
            // Variables
            int len = 100;
            Empleado[] empleados = new Empleado[len];   
            int contador = 0;
            char ingreso;

            // Ingreso de datos
                for (int i = 0; i < len; i++)
                {
                    Console.Write("Ingrese el valor de la hora del empleado: ");
                    empleados[i].valorHora = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese nombre del empleado: ");
                    empleados[i].nombre = Console.ReadLine();
                    Console.Write("Ingrese antiguedad: ");
                    empleados[i].antiguedad = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
                    empleados[i].horasPorMes = float.Parse(Console.ReadLine());

                    empleados[i].totalHoras = empleados[i].valorHora * empleados[i].horasPorMes;
                    empleados[i].totalAntiguedad = empleados[i].antiguedad * 150;
                    empleados[i].totalBruto = empleados[i].totalHoras + empleados[i].totalAntiguedad;
                    empleados[i].totalDescuento = (float)(empleados[i].totalBruto * 1.13) - empleados[i].totalBruto;
                    empleados[i].totalNeto = empleados[i].totalBruto - empleados[i].totalDescuento;
                    contador++;

                    Console.Write("Presion [s] para ingresar otro empleado: ");
                    ingreso = char.Parse(Console.ReadLine());

                    if (ingreso != 's')
                    {
                        break;
                    }
                    
                }

            //Mostrar en pantalla

            Console.Clear();
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "   Nombre: {0}" + "\n" +
                            "   Antiguedad: {1} años" + "\n" +
                            "   Valor por hora: ${2,0:#,###.00}" +   "\n" +
                            "   Total sueldo bruto: ${3,0:#,###.00}" +   "\n" +
                            "   Descuentos a aplicar: ${4,0:#,###.00}" +   "\n" +
                            "   -----------------" + "\n" +
                            "   Total sueldo neto: ${5,0:#,###.00}", empleados[i].nombre,
                                                        empleados[i].antiguedad,
                                                        empleados[i].valorHora,
                                                        empleados[i].totalBruto,
                                                        empleados[i].totalDescuento,
                                                        empleados[i].totalNeto + "\n");

            }
                
            Console.ReadLine();
        }
        }
}
