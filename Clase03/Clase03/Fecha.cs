using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    public class Fecha
    {
        int dia;
        int mes;
        int anio;

        public Fecha()
        {
            this.dia = 01;
            this.mes = 01;
            this.anio = 1900;
        }

        public Fecha(int anio, int mes, int dia)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public double CalcularEdad()
        {
            double edad;

            DateTime miFecha = new DateTime(this.anio, this.mes, this.dia);
            DateTime fechaActual = DateTime.Now;

            edad = (fechaActual - miFecha).TotalDays / 365;


            return edad;
        }
    }
}
