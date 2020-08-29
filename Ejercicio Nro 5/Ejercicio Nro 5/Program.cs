using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_5
{
    class Program
    {
        /*Crear una app que calcule los centros numericos entre 1 y el dato ingresado x consola*/

        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 05";

            double contador = 1;
            double numero;
            int i;
            double j;
            double acumuladorInf;
            double acumuladorSup;

            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console.ReadLine());

            while (contador < numero)
            {

                contador++;
                acumuladorInf = 0;
                acumuladorSup = 0;

                for (i = 1; i < contador; i++)
                {
                    acumuladorInf += i;
                }

                for (j = contador + 1; j <= acumuladorInf; j++)
                {
                    if ((acumuladorSup == acumuladorInf) || (acumuladorSup > acumuladorInf))
                        break;
                    acumuladorSup += j;
                }


                if (acumuladorInf == acumuladorSup)
                    Console.WriteLine($"{contador} es centro numerico");
            }

            Console.ReadKey();
        }


    }
}
