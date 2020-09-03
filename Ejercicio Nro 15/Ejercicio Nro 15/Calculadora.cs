using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    class Calculadora
    {
        public static double Calcular(double valor1, double valor2, char operacion)
        {
            double resultado=0;

            if (operacion == '+')
            {
                resultado = valor1 + valor2;
            } 
            else if (operacion == '-')
            {
                resultado = valor1 - valor2;
            }
            else if (operacion == '*')
            {
                resultado = valor1 * valor2;
            }
            else if (operacion == '/')
            {
                if(Validar(valor2))
                resultado = valor1 / valor2;
            }

            return resultado;
        }

        private static bool Validar(double valor2)
        {
            bool retorno = false;

            if (valor2 != 0)
                retorno = true;

            return retorno;
        }
    }
}
