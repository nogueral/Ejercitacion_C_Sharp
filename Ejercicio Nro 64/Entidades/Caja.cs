using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        List<string> filaClientes;

        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
        }

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach (string item in this.filaClientes)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {item}");
                Thread.Sleep(2000);
            }
        }

    }
}
