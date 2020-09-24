using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Peso
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Peso()
        {
            cotizRespectoDolar = 66;
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Peso auxPeso)
        {
            double auxCantidad = auxPeso.cantidad / Peso.GetCotizacion();

            return new Dolar(auxCantidad);
        }

        public static bool operator ==(Peso auxPeso, Dolar auxDolar)
        {
            bool retorno = false;

            if (auxDolar.GetCantidad() == auxPeso.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Peso auxPeso, Dolar auxDolar)
        {
            return !(auxDolar.GetCantidad() == auxPeso.GetCantidad());
        }

        public static Peso operator +(Peso auxPeso, Dolar auxDolar)
        {
            Peso aux = new Peso();
            double auxCantidad;

            aux = (Peso)auxDolar;

            auxCantidad = aux.GetCantidad() + auxPeso.GetCantidad();

            return new Peso(auxCantidad);
        }

        public static Peso operator -(Peso auxPeso, Dolar auxDolar)
        {
            Peso aux = new Peso();
            double auxCantidad;

            aux = (Peso)auxDolar;

            auxCantidad = aux.GetCantidad() - auxPeso.GetCantidad();

            return new Peso(auxCantidad);
        }
    }
}
