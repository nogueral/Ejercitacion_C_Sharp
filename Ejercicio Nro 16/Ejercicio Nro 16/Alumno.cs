using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_16
{
    class Alumno
    {
       private byte nota1;
       private byte nota2;
       private float notaFinal;
       private string apellido;
       private int legajo;
       private string nombre;
     

       public void SetNombre (string auxNombre)
       {
            this.nombre = auxNombre;
       }

        public void SetApellido (string auxApellido)
        {
            this.apellido = auxApellido;
        }
        public void SetLegajo(int auxLegajo)
        {
            this.legajo = auxLegajo;
        }

        private void CalcularFinal()
        {
            if(this.nota1>=4 && this.nota2>=4)
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
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Legajo: {0}", this.legajo);
            Console.WriteLine("Nota 1: {0}", this.nota1);
            Console.WriteLine("Nota 2: {0}", this.nota2);
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nota Final: {0}", this.notaFinal);
            }
            else
            {
                Console.WriteLine("Nota Final: Alumno desaprobado");
            }
            
            Console.WriteLine("------------------------------------");
        }

 
    }
}
