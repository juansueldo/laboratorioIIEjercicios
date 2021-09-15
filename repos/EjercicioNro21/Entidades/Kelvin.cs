using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Kelvin
    {
        #region Objetos
        private double temperatura;
        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        #endregion
        #region Conversiones
        public static implicit operator Kelvin(double k)
        {
            Kelvin aux = new Kelvin(k);
            return aux;
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetTemperatura() * 9 / 5) - 459.67);
        }
        #endregion
        #region Comparaciones
        public static bool operator == (Kelvin k1, Kelvin k2)
        {
            return (k1.temperatura == k2.temperatura);
        }
        public static bool operator != (Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }
        public static bool operator == (Kelvin k, Fahrenheit f)
        {

            return k == (Kelvin)f;
        }
        public static bool operator != (Kelvin p, Fahrenheit d)
        {
            return !(p == d);
        }
        public static bool operator == (Kelvin p, Celsius e)
        {

            return p == (Kelvin)e;
        }
        public static bool operator != (Kelvin p, Celsius e)
        {
            return !(p == e);
        }
        #endregion
        #region Operaciones
        public static Kelvin operator + (Kelvin k, Fahrenheit f)
        {
            Kelvin aux = new Kelvin(k.temperatura + ((Kelvin)f).temperatura);
            return aux;
        }
        public static Kelvin operator - (Kelvin p, Fahrenheit d)
        {
            Kelvin aux = new Kelvin(p.temperatura - ((Kelvin)d).temperatura);
            return aux;
        }
        public static Kelvin operator +(Kelvin p, Celsius e)
        {
            Kelvin aux = new Kelvin(p.temperatura + ((Kelvin)e).temperatura);
            return aux;
        }
        public static Kelvin operator - (Kelvin p, Celsius e)
        {
            Kelvin aux = new Kelvin(p.temperatura - ((Kelvin)e).temperatura);
            return aux;
        }
        #endregion
    }
}
