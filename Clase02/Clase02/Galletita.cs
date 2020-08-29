using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Galletita
    {
        private string sabor;
        private bool bajasCalorias;

        public string GetSabor()
        {
            return this.sabor;
        }

        /// <summary>
        /// Setea el parametro sabor
        /// </summary>
        /// <param name="auxSabor"></param>
        public void SetSabor(string auxSabor)
        {
            this.sabor = auxSabor;
        }
    }
}
