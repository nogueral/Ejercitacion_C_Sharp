using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad <T, U> where T : Documento where U : Documento, new()
    {
        List<T> ingresos;
        List<U> egresos;

        public Contabilidad()
        {
            ingresos = new List<T>();
            egresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T, U> c, U egreso)
        {
            c.egresos.Add(egreso);

            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T ingreso)
        {
            c.ingresos.Add(ingreso);

            return c;
        }
    }
}
