using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Leyendo...");
                Persona pers = PersonaDAO.LeerPorID(11);
                Console.WriteLine(pers.ToString());
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Modificando...");
                pers.Apellido = "Lopez";
                pers.Nombre = "Miguel";
                if (pers.Modificar())
                    Console.WriteLine("Modificado!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Eliminando...");
                if (pers.Eliminar())
                    Console.WriteLine("Eliminado!");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
                Console.Clear();
            }

            try
            {
                List<Persona> personas = new List<Persona>();

                Persona p = new Persona("Juan", "Perez", 5555555);
                Console.WriteLine("");
                Console.WriteLine("Guardando...");
                if (p.Guardar())
                    Console.WriteLine("Guardado!");
                Console.ReadKey();
                Console.Clear();

                personas = PersonaDAO.Leer();

                foreach (Persona personita in personas)
                {
                    Console.WriteLine(personita.ToString());
                }

                Console.ReadKey();
                Console.Clear();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


        }
    }
}
