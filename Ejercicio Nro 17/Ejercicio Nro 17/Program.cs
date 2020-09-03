using BoligrafoSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_Nro_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";

            byte opcion;
            short gasto;
            string pintarAzul;
            string pintarRojo;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            do
            {
                Console.WriteLine("******Boligrafo******");
                Console.WriteLine("1. Pintar boligrafo azul: ");
                Console.WriteLine("2. Pintar boligrafo rojo: ");
                Console.WriteLine("3. Recargar boligrafo azul: ");
                Console.WriteLine("4. Recargar boligrafo rojo: ");
                Console.Write("5. Salir: ");
                byte.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine("*********************");

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese gasto de tinta: ");
                        short.TryParse(Console.ReadLine(), out gasto);

                        if(boligrafoAzul.Pintar(gasto, out pintarAzul))
                        {
                            Console.ForegroundColor = boligrafoAzul.GetColor();
                            Console.WriteLine($"Dibujo: {pintarAzul}");
                            Console.ForegroundColor = ConsoleColor.White;
                        } 
                        else
                        {
                            Console.WriteLine("No hay suficiente nivel de tinta, realice una recarga");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese gasto de tinta: ");
                        short.TryParse(Console.ReadLine(), out gasto);

                        if(boligrafoRojo.Pintar(gasto, out pintarRojo))
                        {
                            Console.ForegroundColor = boligrafoRojo.GetColor();
                            Console.WriteLine($"Dibujo: {pintarRojo}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine("No hay suficiente nivel de tinta, realice una recarga");
                        }
                        break;
                    case 3:
                        boligrafoAzul.Recargar();
                        break;
                    case 4:
                        boligrafoRojo.Recargar();
                        break;
                }

            } while (opcion!=5);

            Console.ReadKey();
        }
    }
}
