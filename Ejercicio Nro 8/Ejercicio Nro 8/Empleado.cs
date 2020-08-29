using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_8
{
    class Empleado
    {
        private int cantidadHoras;
        private string nombre;
        private int antiguedad;
        private float valorHora;

        public void SetCantidadHoras(int auxCantHoras)
        {
            this.cantidadHoras = auxCantHoras;
        }

        public void SetNombre(string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public void SetAntiguedad(int auxAntiguedad)
        {
            this.antiguedad = auxAntiguedad;
        }

        public void SetValorHora(float auxValorHora)
        {
            this.valorHora = auxValorHora;
        }

        public void GetSueldo()
        {
            float sueldo;
            float descuento;

            sueldo = (this.valorHora * this.cantidadHoras) + (this.antiguedad * 150);
            descuento = sueldo * 13 / 100;

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Nombre: {this.nombre}");
            Console.WriteLine($"Antiguedad: {this.antiguedad}");
            Console.WriteLine($"Valor hora: {this.valorHora}");
            Console.WriteLine($"Sueldo: {sueldo}");
            Console.WriteLine($"Descuento: {descuento}");
            Console.WriteLine($"Neto a cobrar: {sueldo-descuento}");
            Console.WriteLine("---------------------------");
        }
    }
}
