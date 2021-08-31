using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double area)
        {
            double resultado;
            resultado = (area * area);
            return resultado;
        }
        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double resultado;
            resultado = (baseTriangulo * altura) / 2;
            return resultado;
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado;
            resultado = 3.14 * radio * radio;
            return resultado;
        }
    }
}
