using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Celsius
    {
        #region Objetos
        private double temperatura;


        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        #endregion
        #region Conversiones
        public static explicit operator Kelvin(Celsius c)
        {
            return (Kelvin)((Fahrenheit)c);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetTemperatura() * (9 / 5) + 32);
        }

        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }
        #endregion
        #region Comparaciones
        public static bool operator == (Celsius e1, Celsius e2)
        {
            return (e1.temperatura == e2.temperatura);
        }
        public static bool operator !=(Celsius e1, Celsius e2)
        {
            return !(e1 == e2);
        }
        public static bool operator == (Celsius e, Fahrenheit d)
        {

            return e == (Celsius)d;
        }
        public static bool operator != (Celsius e, Fahrenheit d)
        {
            return !(e == d);
        }
        public static bool operator == (Celsius e, Kelvin p)
        {

            return e == (Celsius)p;
        }
        public static bool operator !=(Celsius e, Kelvin p)
        {
            return !(e == p);
        }
        #endregion
        #region Operaciones
        public static Celsius operator + (Celsius e, Fahrenheit d)
        {
            Celsius aux = new Celsius(e.temperatura + ((Celsius)d).temperatura);
            return aux;
        }
        public static Celsius operator - (Celsius e, Fahrenheit d)
        {
            Celsius aux = new Celsius (e.temperatura - ((Celsius)d).temperatura);
            return aux;
        }
        public static Celsius operator + (Celsius e, Kelvin p)
        {
            Celsius aux = new Celsius(e.temperatura + ((Celsius)p).temperatura);
            return aux;
        }
        public static Celsius operator -(Celsius e, Kelvin p)
        {
            Celsius aux = new Celsius(e.temperatura - ((Celsius)p).temperatura);
            return aux;
        }
        #endregion
    }
}
