using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16bis
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;
        bool alta = false;


        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public void SetApellido(string auxApellido)
        {
            this.apellido = auxApellido;
        }
        public void SetLegajo(int auxLegajo)
        {
            this.legajo = auxLegajo;
        }

        private void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                notaFinal = (this.nota1 + this.nota2) / 2;

            }
            else
            {
                notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
            CalcularFinal();
        }

        public void Mostrar()
        {
            if (this.alta == true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Nombre: {0}", this.nombre);
                Console.WriteLine("Apellido: {0}", this.apellido);
                Console.WriteLine("Legajo: {0}", this.legajo);
                Console.WriteLine("Nota 1: {0}", this.nota1);
                Console.WriteLine("Nota 2: {0}", this.nota2);
                Console.WriteLine("Nota Final: {0}", this.notaFinal);
                Console.WriteLine("------------------------------------");
            }

        }

        public static int BuscarLibre (Alumno[] listaAlumnos)
        {
            int indice = -1;

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                if(listaAlumnos[i].alta == false)
                {
                    indice = i;
                    break;
                } 
            }

            return indice;
        }

        public static bool AltaAlumno(Alumno[] listaAlumnos)
        {
            bool retorno = false;
            int indice;
            int auxLegajo;


            indice = BuscarLibre(listaAlumnos);

            if (indice != -1)
            {

                Console.Write("Ingresar nombre: ");
                listaAlumnos[indice].SetNombre(Console.ReadLine());

                Console.Write("Ingresar apellido: ");
                listaAlumnos[indice].SetApellido(Console.ReadLine());

                Console.Write("Ingresar legajo: ");
                int.TryParse(Console.ReadLine(), out auxLegajo);
                listaAlumnos[indice].SetLegajo(auxLegajo);

                listaAlumnos[indice].alta = true;

                retorno = true;
            }

            return retorno;
        }

        public static bool BajaAlumno(Alumno[] listaAlumnos)
        {
            bool retorno = false;
            int auxLegajo;
            int indice = -1;

            Console.WriteLine("Ingrese legajo: ");
            int.TryParse(Console.ReadLine(), out auxLegajo);

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                if(listaAlumnos[i].legajo == auxLegajo)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                listaAlumnos[indice].alta = false;
                retorno = true;
            }

            return retorno;
        }

        public static bool ModificarAlumno (Alumno[] listaAlumnos)
        {
            bool retorno = false;
            int indice = -1;
            int auxLegajo;


            Console.WriteLine("Ingrese legajo: ");
            int.TryParse(Console.ReadLine(), out auxLegajo);

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                if (listaAlumnos[i].legajo == auxLegajo)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {

                Console.Write("Ingresar nombre: ");
                listaAlumnos[indice].SetNombre(Console.ReadLine());

                Console.Write("Ingresar apellido: ");
                listaAlumnos[indice].SetApellido(Console.ReadLine());

                retorno = true;
            }

            return retorno;
        }

        public static bool CargarNota(Alumno[] listaAlumnos)
        {
            bool retorno = false;
            int indice = -1;
            int auxLegajo;
            byte auxNota1;
            byte auxNota2;

            Console.WriteLine("Ingrese legajo: ");
            int.TryParse(Console.ReadLine(), out auxLegajo);

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                if (listaAlumnos[i].legajo == auxLegajo)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Random calificacion = new Random();

                auxNota1 = (byte)calificacion.Next(1, 10);
                auxNota2 = (byte)calificacion.Next(1, 10);

                listaAlumnos[indice].Estudiar(auxNota1, auxNota2);

                retorno = true;
            }

            return retorno;
        }

        public static bool MostrarAlumno (Alumno[] listaAlumnos)
        {
            bool retorno = false;

            for (int i = 0; i < listaAlumnos.Length; i++)
            {
                listaAlumnos[i].Mostrar();
            }


            return retorno;
        }
    }
}
