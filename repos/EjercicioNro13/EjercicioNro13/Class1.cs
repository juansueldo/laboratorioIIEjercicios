using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro13
{
    class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string retorno = "";
            const int DIVISOR = 2;
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % DIVISOR == 0)
                    {
                        retorno = "0" + retorno;
                    }
                    else
                    {
                        retorno = "1" + retorno;
                    }
                    numero = numero / 2;
                }
            }
            else
            {
                retorno = "El numero debe ser positivo";
            }
            return retorno;
        }
        public static int BinarioDecimal(string cadena)
        {
            char[] array = cadena.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int entero = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición

                    entero += (int)Math.Pow(2, i);
                }
            }
            return entero;
        }
    }
}
