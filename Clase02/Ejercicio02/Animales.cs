using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Animales
    {
       private string tipo;
       private string nombre;
       private double peso;
       private int edad;

       public Animales(string tipo, string nombre, double peso, int edad)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.peso = peso;
            this.edad = edad;
        }

       public void SetTipo(string auxTipo)
        {
            this.tipo = auxTipo;

        }

        public void SetPeso(double auxPeso)
        {
            this.peso = auxPeso;

        }

        public void SetEdad(int auxEdad)
        {
            this.edad = auxEdad;

        }

        public void SetNombre (string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public double GetPeso()
        {
            return this.peso;
        }

        public int GetEdad()
        {
            return this.edad;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetTipo()
        {
            return this.tipo;
        }
    }
}
