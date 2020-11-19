using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punta_de_Caja
{
    public class Persona
    {

        List<Factura> facturas;
        string nombre;

        public Persona()
        {

        }

        public Persona(string nombre)
        {
            facturas = new List<Factura>();
            this.nombre = nombre;
        }

        public List<Factura> Facturas { get => facturas; set => facturas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
