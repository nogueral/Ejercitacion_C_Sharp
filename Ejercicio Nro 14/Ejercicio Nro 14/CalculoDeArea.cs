using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    class CalculoDeArea
    {
        public static double CalculoCuadrado (double lado)
        {
            return lado * lado;
        }

        public static double CalculoTriangulo(double valorBase, double valorAltura)
        {
            return (valorBase * valorAltura) / 2;
        }

        public static double CalculoCirculo(double radio)
        {
            return 3.14 * radio * radio;
        }
    }
}
