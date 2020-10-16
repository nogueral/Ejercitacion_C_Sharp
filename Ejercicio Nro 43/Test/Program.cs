using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarreraDeAutos;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 43";

            AutoF1 a1 = new AutoF1(54, "Ford", 120);
            AutoF1 a2 = new AutoF1(100, "Renault", 92);
            MotoCross a3 = new MotoCross(88, "KTM", 250);
            AutoF1 a4 = new AutoF1(82, "BMW", 190);
            AutoF1 a5 = new AutoF1(16, "VW", 88);
            AutoF1 a6 = new AutoF1(23, "Fiat", 115);

            Competencia competencia = new Competencia(4, 6, Competencia.TipoCompetencia.F1);

            try
            {
                if (competencia + a1)
                {
                    Console.WriteLine(a1.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            try
            {
                if (competencia + a2)
                {
                    Console.WriteLine(a2.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            try
            {
                if (competencia + a2)
                {
                    Console.WriteLine(a2.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            try
            {
                if (competencia + a3)
                {
                    Console.WriteLine(a3.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

 

            Console.ReadKey();
            Console.Clear();

            try
            {
                if (competencia + a4)
                {
                    Console.WriteLine(a4.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
            Console.Clear();

            try
            {
                if (competencia + a5)
                {
                    Console.WriteLine(a5.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            try
            {
                if (competencia + a6)
                {
                    Console.WriteLine(a6.MostrarDatos());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
