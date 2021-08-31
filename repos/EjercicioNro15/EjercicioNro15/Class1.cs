using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro15
{
    public static class Calculadora
    {
        public static double Calcular (double numero1, double numero2, char operador)
        {
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if(Validar(numero2) == true)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("No es un posible dividir por cero");
                    }        
                    break;
                default:
                    Console.WriteLine("No es un operdaor valido");
                    break;
            }
            return resultado;
        }
        private static bool Validar (double numero2)
        {
            bool retorno = false;
            if(numero2 > 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
