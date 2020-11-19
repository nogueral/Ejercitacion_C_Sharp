﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        Caja caja1;
        Caja caja2;
        List<string> clientes;

        public Caja Caja1
        {
            get { return this.caja1; }
        }

        public Caja Caja2
        {
            get { return this.caja2; }
        }

        public List<string> Clientes
        {
            get { return this.clientes; }
        }

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");

            foreach (string item in this.clientes)
            {
                if(caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(item);
                } else
                {
                    caja2.FilaClientes.Add(item);
                }

                Thread.Sleep(1000);
            }
        }
    }
}
