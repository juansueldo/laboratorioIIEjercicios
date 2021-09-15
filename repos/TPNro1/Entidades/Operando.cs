using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero) :this()
        {
            SetNumero = strNumero;
        }
        private double ValidarOperando(string strNumero)
        {
            double retorno;
            if(double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            else
            {
                return  0;
            }
        }
        public string SetNumero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            for(int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '0' && binario[i] != '1')
                {
                    return retorno;
                }
                else
                {
                    retorno = true;
                    
                }
            }
            return retorno;
        }
        public string BinarioDecimal(string binario)
        {
            if(EsBinario(binario)== true)
            {
                double resultado = 0;
                for (int i = 0; i < binario.Length; i++)
                {
                    resultado += int.Parse(binario[i].ToString()) * (Math.Pow(2, binario.Length - 1 - i));
                }
                return resultado.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }
        public string DecimalBinario(double numero)
        {
            int auxNumero = (int)numero;
            if(auxNumero > 0)
            {
                string resultado = "";
                do
                {
                    resultado = (auxNumero % 2) + resultado;
                    auxNumero = (int)auxNumero / 2;
                } while (auxNumero > 0);
                return resultado;
            }
            else
            {
                return "Valor inválido";
            }
                
        }
        public string DecimalBinario(string numero)
        {
            if (!double.TryParse(numero, out double auxNumero))
            {
                return "Valor inválido";
            }
            return DecimalBinario(auxNumero);
        }
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator / (Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
            
        }
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

    }
}
