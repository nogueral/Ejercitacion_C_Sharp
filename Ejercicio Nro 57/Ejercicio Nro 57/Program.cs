using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 57";

            Persona pers = new Persona("Leandro", "Noguera");

            try
            {
                if (Persona.Guardar(pers))
                {
                    Console.WriteLine("Archivo guardado");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            try
            {
                Persona persona2 = Persona.Leer();
                Console.WriteLine("Archivo leido con exito!\n");
                Console.WriteLine(persona2.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
