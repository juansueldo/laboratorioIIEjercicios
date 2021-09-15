using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    static class Calculadora
    {
        private static char ValidarOperando(char operador)
        {
            switch (operador)
            {
                case '+':
                    return '+';
                    break;
                case '-':
                    return '-';
                    break;
                case '*':
                    return '*';
                    break;
                case '/':
                    return '/';
                    break;
                default:
                    return '+';
            }
        }
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (Calculadora.ValidarOperando(operador))
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return double.MinValue;
            }
        }
    }
}
