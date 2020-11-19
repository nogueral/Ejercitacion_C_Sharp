using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("a");
            negocio.Clientes.Add("b");
            negocio.Clientes.Add("c");
            negocio.Clientes.Add("d");
            negocio.Clientes.Add("e");
            negocio.Clientes.Add("f");

            Thread hiloNegocio = new Thread(negocio.AsignarCaja);
            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);

            hiloCaja1.Name = "Caja 1";
            hiloCaja2.Name = "Caja 2";

            hiloNegocio.Start();
            hiloNegocio.Join();
            hiloCaja1.Start();
            hiloCaja2.Start();


            Console.ReadKey();
        }
    }
}
