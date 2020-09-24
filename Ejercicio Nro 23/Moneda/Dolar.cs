using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Peso(Dolar auxDolar)
        {
            double auxCantidad = auxDolar.cantidad * Peso.GetCotizacion();

            return new Peso(auxCantidad);
        }

        public static bool operator ==(Dolar auxDolar, Peso auxPeso)
        {
            bool retorno = false;

            if (auxDolar.GetCantidad() == auxPeso.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar auxDolar, Peso auxPeso)
        {
            return !(auxDolar.GetCantidad() == auxPeso.GetCantidad());
        }

        public static Dolar operator +(Dolar auxDolar, Peso auxPeso)
        {
            Dolar aux = new Dolar();
            double auxCantidad;

            aux = (Dolar)auxPeso;

            auxCantidad = aux.GetCantidad() + auxDolar.GetCantidad();

            return new Dolar(auxCantidad);
        }

        public static Dolar operator -(Dolar auxDolar, Peso auxPeso)
        {
            Dolar aux = new Dolar();
            double auxCantidad;

            aux = (Dolar)auxPeso;

            auxCantidad = aux.GetCantidad() - auxDolar.GetCantidad();

            return new Dolar(auxCantidad);
        }
    }
}
