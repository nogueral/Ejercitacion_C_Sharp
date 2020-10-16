using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(54, "Ford");
            AutoF1 a2 = new AutoF1(100, "Renault");
            AutoF1 a3 = new AutoF1(88, "Fiat");
            AutoF1 a4 = new AutoF1(82, "Chevrolet");
            AutoF1 a5 = new AutoF1(16, "VW");
            AutoF1 a6 = new AutoF1(23, "Fiat");

            Competencia competencia = new Competencia(4, 6);



            if (competencia + a1)
            {
                Console.WriteLine(a1.MostrarDatos());
            }

            Console.ReadKey();
            Console.Clear();

            if (competencia + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            }

            Console.ReadKey();
            Console.Clear();

            if (competencia + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            } else
            {
                Console.WriteLine("Ya existe en la lista");
            }

            Console.ReadKey();
            Console.Clear();

            if (competencia + a3)
            {
                Console.WriteLine(a3.MostrarDatos());
            }

            Console.ReadKey();
            Console.Clear();

            if (competencia + a4)
            {
                Console.WriteLine(a4.MostrarDatos());
            }

            Console.ReadKey();
            Console.Clear();

            if (competencia + a5)
            {
                Console.WriteLine(a5.MostrarDatos());
            } else
            {
                Console.WriteLine("Sin espacio");
            }

            Console.ReadKey();
            Console.Clear();

            if (competencia + a6)
            {
                Console.WriteLine(a6.MostrarDatos());
            }
            else
            {
                Console.WriteLine("Sin espacio");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
