using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Objetos
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.8;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion
        #region Conversiones
        public static implicit operator Euro(double e)
        {
            Euro aux = new Euro(e);
            return aux;
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Dolar.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Pesos.GetCotizacion());
        }
        #endregion
        #region Comparaciones
        public static bool operator == (Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator == (Euro e, Dolar d)
        {

            return e == (Euro)d;
        }
        public static bool operator != (Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator == (Euro e, Pesos p)
        {

            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        #endregion
        #region Operaciones
        public static Euro operator + (Euro e, Dolar d)
        {
            Euro aux = new Euro(e.cantidad + ((Euro)d).cantidad);
            return aux;
        }
        public static Euro operator - (Euro e, Dolar d)
        {
            Euro aux = new Euro (e.cantidad - ((Euro)d).cantidad);
            return aux;
        }
        public static Euro operator + (Euro e, Pesos p)
        {
            Euro aux = new Euro(e.cantidad + ((Euro)p).cantidad);
            return aux;
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            Euro aux = new Euro(e.cantidad - ((Euro)p).cantidad);
            return aux;
        }
        #endregion
    }
}
