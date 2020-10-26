using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<SerVivo> listaSerVivo = new List<SerVivo>();
            listaSerVivo.Add(new Aborigen("lumpa lumpa", 50, "wololo"));
            listaSerVivo.Add(new Lobo(" wolverine ", 90));
            listaSerVivo.Add(new Aguila("Birdman", 90));


            List<Humano> listaHumano = new List<Humano>();
            listaHumano.Add(new Aborigen("lumpa lumpa", 50, "wololo"));
            listaHumano.Add(new Piloto(" Maverick", 20, "Cruise"));

            List<Animal> listaAnimales = new List<Animal>();
            listaAnimales.Add(new Colibri(" wolverine ", 1));
            listaAnimales.Add(new Aguila("pajarin", 90));
            listaAnimales.Add(new Jirafa(" Marvin", 110));


            List<Lobo> listaLobitos = new List<Lobo>();
            listaLobitos.Add(new Lobo("chufi chufi", 40));


            List<IVolador> listaDeVoladores = new List<IVolador>();

            listaDeVoladores.Add(new Espiritu());
            listaDeVoladores.Add(new Aguila("aguiluchoo",50));
            listaDeVoladores.Add(new Piloto("MAVERICK",67,"Boeing"));


            foreach (IVolador auxVoladores in listaDeVoladores)
            {
                auxVoladores.Volar();
                Console.WriteLine(auxVoladores.EnElAire);
            }

            Espiritu miEspirituChocarrero = new Espiritu();

            miEspirituChocarrero.Moverse();   // implicito 

            // explicito,hay que castearlo para verlo
            ((ICazador)miEspirituChocarrero).Moverse(); 



          


            Console.ReadKey();
        }
    }
}
