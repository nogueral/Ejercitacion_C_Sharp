using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    class Espiritu : IVolador, ICazador
    {
        public string EnElAire
        {
            get
            {
                return "buuuu";
            }
        }

        public void Cazar()
        {
            Console.WriteLine("Ya los voy a agarrar....");
        }

        void ICazador.Moverse()
        {
            Console.WriteLine("Movete cazador lalalala");
        }


        public void Moverse()
        {
            
            Console.WriteLine("Movete Volador lalalala");
        }


        public void Volar()
        {
            Console.WriteLine(" Me ahorro la nafta");
        }
    }
}
