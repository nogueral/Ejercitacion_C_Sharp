﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 40";
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            try
            {
                c = c + l1;
                Console.WriteLine(c.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            Console.Clear();

            try
            {
                c = c + l2;
                Console.WriteLine(c.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            Console.Clear();

            try
            {
                c = c + l3;
                Console.WriteLine(c.ToString());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
            Console.Clear();

            try
            {
                c = c + l4;
                Console.WriteLine(c.ToString());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nMUESTRA LLAMADAS ORDENADAS\n");
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
