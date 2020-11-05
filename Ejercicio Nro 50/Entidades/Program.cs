using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Double d = -2.345;
            //int i = (int)Convert.ChangeType(d, typeof(int));

            //Console.WriteLine("The double value {0} when converted to an int becomes {1}", d, i);

            //string s = "12/12/98";
            //DateTime dt = (DateTime)Convert.ChangeType(s, typeof(DateTime));

            //Console.WriteLine("The string value {0} when converted to a Date becomes {1}", s, dt);

            GuardarTexto<string, string> guardar = new GuardarTexto<string, string>();

            Console.WriteLine(guardar.Leer());

            Serializar<string, string> serializar = new Serializar<string, string>();

            Console.WriteLine(serializar.Leer());
        }
    }
}
