using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punta_de_Caja
{
    public class Cajero
    {
        
        public string numero;

        public void AtenderPersona()
        {
            if (Banco.personas.Count > 0)
            {
                this.Cobrar(Banco.personas.Dequeue());
            }
           
        }

        public void Cobrar(Persona pers)
        {
            double monto=0;

            foreach (Factura item in pers.Facturas)
            {
                monto += item.Precio;
            }

            Console.WriteLine("Se cobro a: " + pers.Nombre + " el monto: $" + monto);

            this.AtenderPersona();
        }
    }
}
