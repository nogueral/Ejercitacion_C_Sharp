﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_42
{
    class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje, Exception e) : base(mensaje, e)
        {

        }
    }
}
