using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Fahrenheit
    {
        #region Objetos
        private double temperatura;

        public Fahrenheit (double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura ()
        {
            return this.temperatura;
        }

        #endregion
        #region Conversiones
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetTemperatura() + 459.67) * 5 / 9);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetTemperatura() - 32) * 5 / 9);
        }

        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }
        #endregion
        #region Comparaciones
        public static bool operator ==(Fahrenheit d1, Fahrenheit d2)
        {
            return (d1.temperatura == d2.temperatura);
        }
        public static bool operator !=(Fahrenheit d1, Fahrenheit d2)
        {
            return !(d1 == d2);
        }
        public static bool operator == (Fahrenheit d, Celsius e)
        {

            return d == (Fahrenheit)e;
        }
        public static bool operator !=(Fahrenheit d, Celsius e)
        {
            return !(d == e);
        }
        public static bool operator ==(Fahrenheit d, Kelvin p)
        {

            return d == (Fahrenheit)p;
        }
        public static bool operator !=(Fahrenheit d, Kelvin p)
        {
            return !(d == p);
        }
        #endregion
        #region Operaciones
        public static Fahrenheit operator +(Fahrenheit d, Kelvin p)
        {
            Fahrenheit aux = new Fahrenheit(d.temperatura + ((Fahrenheit)p).temperatura);
            return aux;
        }
        public static Fahrenheit operator - (Fahrenheit d, Kelvin p)
        {
            Fahrenheit aux = new Fahrenheit(d.temperatura - ((Fahrenheit)p).temperatura);
            return aux;
        }
        public static Fahrenheit operator + (Fahrenheit p, Celsius e)
        {
            Fahrenheit aux = new Fahrenheit(p.temperatura + ((Fahrenheit)e).temperatura);
            return aux;
        }
        public static Fahrenheit operator - (Fahrenheit p, Celsius e)
        {
            Fahrenheit aux = new Fahrenheit(p.temperatura - ((Fahrenheit)e).temperatura);
            return aux;
        }
        #endregion
    }
}
