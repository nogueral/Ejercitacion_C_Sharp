using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzzFest
{
    static class Festival
    {
        static List<Banda> listaBandas;
        static string nombreFestival;

        static Festival()
        {
            listaBandas = new List<Banda>();
            nombreFestival = "EzzFest";
        }

        public static double DuracionTotal()
        {
            double duracion=0;

            for (int i = 0; i < listaBandas.Count; i++)
            {
                duracion += listaBandas[i].Tiempo;
            }

            return duracion;
        }
    }
}
