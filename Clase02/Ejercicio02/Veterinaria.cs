using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    static class Veterinaria
    {
        static Animales[] listaAnimales;

        static Veterinaria()
        {
            listaAnimales = new Animales[5];
        }

        /// <summary>
        /// Realiza la carga de un objeto mascota a un array
        /// </summary>
        /// <param name="auxMascota"></param>
        /// <returns> devuelve true si lo pudo hacer o false si no se pudo</returns>
        public static bool CargarMascota(Animales auxMascota)
        {
            bool retorno = false;

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if (listaAnimales[i] == null)
                {
                    listaAnimales[i] = auxMascota;
                    retorno = true;
                    break;
                }
            }


            return retorno;
        }

        public static void CacularPromedio()
        {
            double promedio;
            double acumuladorPesos = 0;

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if (listaAnimales[i] != null)
                {
                    acumuladorPesos += listaAnimales[i].GetPeso();
                }
                
            }

            promedio = acumuladorPesos / listaAnimales.Length;

            Console.WriteLine($"El promedio de pesos es: {promedio}");
        }

        public static void PerroMasViejo()
        {
            bool flag = true;
            int mayorEdad = 0;
            string nombreMayor = "";

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if (listaAnimales[i] != null && (flag == true || mayorEdad < listaAnimales[i].GetEdad()))
                {
                    flag = false;
                    mayorEdad = listaAnimales[i].GetEdad();
                    nombreMayor = listaAnimales[i].GetNombre();
                }
            }

            Console.WriteLine($"El nombre del perro mas viejo es: {nombreMayor}");
        }

        /// <summary> muestra por consola mascotas mayores a 10 años que pesen menos de 10kg
        /// 
        /// </summary>
        public static void FiltrarMascotas()
        {
            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if (listaAnimales[i] != null && listaAnimales[i].GetPeso() < 10 && listaAnimales[i].GetEdad() > 10)
                {
                    Console.WriteLine($"Nombre: {listaAnimales[i].GetNombre()}");
                    Console.WriteLine($"Nombre: {listaAnimales[i].GetTipo()}");
                }
            }
        }

        public static void MostrarMascota(string auxNombre)
        {

            for (int i = 0; i < listaAnimales.Length; i++)
            {
                if (listaAnimales[i]!=null && listaAnimales[i].GetNombre() == auxNombre)
                {
                    Console.WriteLine($"Nombre: {listaAnimales[i].GetNombre()}");
                    Console.WriteLine($"Tipo: {listaAnimales[i].GetTipo()}");
                    Console.WriteLine($"Edad: {listaAnimales[i].GetEdad()}");
                    Console.WriteLine($"Peso: {listaAnimales[i].GetPeso()}");
                    break;
                }
            }
        }
    }


}
