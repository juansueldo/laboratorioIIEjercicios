using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro11
{
    public static class Class1
    {
        static public bool Validar(int valor, int min, int max)
        {
            bool retorno;
            if(valor >= min && valor <= max)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
