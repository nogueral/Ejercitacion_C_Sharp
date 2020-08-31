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
       private float peso;
       private int edad;

       public void SetTipo(string auxTipo)
        {
            this.tipo = auxTipo;

            while(this.tipo!="perro" && this.tipo!="gato")
            {
                Console.Write("Error. El tipo debe ser perro o gato. Reingrese: ");
                this.tipo = Console.ReadLine();
            }
        }

        public void SetPeso(float auxPeso)
        {
            this.peso = auxPeso;

            while (this.peso < 1 || this.peso > 100)
            {
                Console.Write("Error. El peso debe estar comprendido entre 1 y 100kg. Reingrese: ");
                float.TryParse(Console.ReadLine(), out this.peso);
            }
        }

        public void SetEdad(int auxEdad)
        {
            this.edad = auxEdad;

            while (this.edad < 1 || this.edad > 25)
            {
                Console.Write("Error. La edad debe estar comprendida entre 1 y 25 años. Reingrese: ");
                int.TryParse(Console.ReadLine(), out this.edad);
            }
        }

        public void SetNombre (string auxNombre)
        {
            this.nombre = auxNombre;
        }

        public float GetPeso()
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
