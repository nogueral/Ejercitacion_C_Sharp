using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Galletita miGalletita = new Galletita();
            Horno miHorno = new Horno();
            Transferencia miTransferencia = new Transferencia();*/

            //Console.WriteLine(miTransferencia.GetCantTransferencias());

            Fecha miFecha = new Fecha();
            Fecha miFecha2 = new Fecha(1987, 12, 28);

            Console.WriteLine("Edad: {0,0:#,###}", miFecha2.CalcularEdad());

        }
    }
}
