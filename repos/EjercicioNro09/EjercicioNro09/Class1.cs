using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro09
{
    public static class MiClaseEstatica
    {
        public static string Mensaje(int i)
        {
           //return "Este es mi primer metodo" + i +" "+ DateTime.Now;
           return string.Format("Este es mi primer metodo {0} {1}", i, DateTime.Now.ToString());
        }
    }
}
