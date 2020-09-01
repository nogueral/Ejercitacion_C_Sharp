using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
     public static class Validaciones
    {    
        public static bool ValidarTipo(string tipo)
        {
            if (tipo == "perro" || tipo == "gato")
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public static bool ValidarPeso(double peso)
        {
            if (peso > 0 && peso < 101)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool ValidarEdad(int edad)
        {
            if (edad > 0 && edad < 26)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
