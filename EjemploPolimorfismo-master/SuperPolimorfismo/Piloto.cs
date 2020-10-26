using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperPolimorfismo
{
    class Piloto : Humano, IVolador
    {
        public Piloto(string nombre, int peso, string apellido) : base(nombre, peso, apellido)
        {
        }

        public string EnElAire 
        {
            get
            {
                return "estoy volando";
            }
        }

        public override void Alimentarse()
        {
            Console.WriteLine(" Me estoy morfando alto asado"); 
        }

        public void Moverse()
        {
            Console.WriteLine("movete vos");
        }

        public void Volar()
        {
            Console.WriteLine("Ya estoy arriba del avion. En 1 seg despego");
        }
    } 
}