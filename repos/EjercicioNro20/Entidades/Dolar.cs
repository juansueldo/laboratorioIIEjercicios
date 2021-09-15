﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Objetos
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar ()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad ()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion
        #region Conversiones
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }
        #endregion
        #region Comparaciones
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator == (Dolar d, Euro e)
        {

            return d == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {

            return d == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        #endregion
        #region Operaciones
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return aux;
        }
        public static Dolar operator - (Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }
        public static Dolar operator + (Dolar p, Euro e)
        {
            Dolar aux = new Dolar(p.cantidad + ((Dolar)e).cantidad);
            return aux;
        }
        public static Dolar operator - (Dolar p, Euro e)
        {
            Dolar aux = new Dolar(p.cantidad - ((Dolar)e).cantidad);
            return aux;
        }
        #endregion
    }
}
