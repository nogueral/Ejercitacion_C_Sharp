using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punta_de_Caja
{
    class Program
    {
        static List<Thread> hilosCajas;


        static void Main(string[] args)
        {
            Random random;
            random = new Random(DateTime.Now.Millisecond);
            hilosCajas = new List<Thread>();

            Banco.personas.Enqueue(CrearPersona());
            Banco.personas.Enqueue(CrearPersona());
            Banco.personas.Enqueue(CrearPersona());
            Banco.personas.Enqueue(CrearPersona());
            Banco.personas.Enqueue(CrearPersona());
            Banco.personas.Enqueue(CrearPersona());
            Banco.personas.Enqueue(CrearPersona());

            Thread hiloCola = new Thread(AgregarPersona);

            for (int i = 0; i < random.Next(2,5); i++)
            {
                Cajero cajero = new Cajero();
                cajero.numero = (i + 1).ToString();
                hilosCajas.Add(new Thread(cajero.AtenderPersona));

            }

            //empieza a agregar gente cada 3 seg
            hiloCola.Start();

            foreach (Thread item in hilosCajas)
            {
                item.Start();
            }

            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");
            Console.WriteLine("Hola");

            hiloCola.Abort();
            Console.WriteLine(Banco.personas.Count);
            Console.ReadKey();
        }

        static void AgregarPersona()
        {
            Banco.personas.Enqueue(CrearPersona());
            Thread.Sleep(3000);
            if (Banco.personas.Count < 20)
            {
                AgregarPersona();
            }

        }


        static Persona CrearPersona()
        {
            Random random = new Random();
            Persona p1 = new Persona();
            p1.Nombre = random.Next().ToString();
            Factura f1 = new Factura();

            for (int i = 0; i < 4; i++)
            {
                f1.Precio = random.Next(100, 800);
                f1.Numero = random.Next(1000, 2000);
                p1.Facturas.Add(f1);
            }


            return p1;
        }
    }
}
