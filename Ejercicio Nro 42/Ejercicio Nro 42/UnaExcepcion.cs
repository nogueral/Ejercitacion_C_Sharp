﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    class UnaExcepcion : Exception
    {
        public UnaExcepcion(string mensaje, Exception e):base(mensaje, e)
        {

        }
    }
}
