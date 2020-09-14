using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar auxDolar = new Dolar(30);
            Peso auxPeso = new Peso(2560);

            Console.Title = "Ejercicio Nro 20";

            
            if (auxDolar == auxPeso)
            {
                Console.WriteLine("Son iguales");
            }

            if (auxPeso != auxDolar)
            {
                Console.WriteLine("Son distintos");
            }

            Dolar auxDolar2 = auxDolar + auxPeso;

            Console.WriteLine("Cantidad dolares: {0:#,###.00}", auxDolar2.GetCantidad());

            Peso auxPeso2 = auxPeso + auxDolar;

            Console.WriteLine("Cantidad Pesos: {0:#,###.00}", auxPeso2.GetCantidad());
        }
    }
}
