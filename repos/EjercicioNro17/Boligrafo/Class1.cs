using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }
        public void Recargar ()
        {
            this.SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = " ";
            if(this.tinta > 0)
            {
                SetTinta(gasto);
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                retorno = true;
            }
            
            return retorno;
        }
    }
}
