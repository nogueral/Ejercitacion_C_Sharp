using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    class Validacion
    {
        /// <summary>
        /// Valida un numero ingresado entre un parametro minimo y uno maximo
        /// </summary>
        /// <param name="valor">el elemento a validar</param>
        /// <param name="min">el parametro minimo</param>
        /// <param name="max">el parametro maximo</param>
        /// <returns>true si esta dentro de los parametros establecidos, false si no lo esta</returns>
        public static bool Validar (int valor, int min, int max)
        {
            bool retorno = false;

            if(valor > min && valor < max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
