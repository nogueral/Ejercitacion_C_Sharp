using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerica.Entidades
{
    class Validaciones <T> where T : IComparable
    {
        public static bool validarValor(T minimo, T maximo, T valorAValidar) 
        {
            return (valorAValidar.CompareTo(maximo) < 0 && valorAValidar.CompareTo(minimo) > 0);
        }
    }
}
