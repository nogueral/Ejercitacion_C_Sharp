using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    public class Galletita
    {
        public string color;
        public string sabor;
        public double precio;
        public TimeSpan tiempoCoccion;

        public Galletita()
        {
            this.precio = 10;
            this.sabor = "chocolate";
            this.color = "negro";
        }
        

        public void Hornear()
        {
            // esperar tiempo coccion
        }


    }
}
