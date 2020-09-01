using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_7
{
    class Program
    {
        /*
         Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año)
        y calcule el número de días vividos por esa persona hasta la fecha actual 
        (tomar la fecha del sistema con DateTime.Now). Nota: Utilizar estructuras selectivas.
        Tener en cuenta los años bisiestos.
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            Console.Write("Por favor, ingrese dia de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Por favor, ingrese mes de nacimiento: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Por favor, ingrese año de nacimiento: ");
            int anio = int.Parse(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            DateTime actual = DateTime.Now;
            
            Console.WriteLine(actual);
            Console.WriteLine(fechaNacimiento);

            Console.WriteLine("Dias vividos: {0, 0: #,###.00}", (actual - fechaNacimiento).TotalDays);
        }
    }
}
