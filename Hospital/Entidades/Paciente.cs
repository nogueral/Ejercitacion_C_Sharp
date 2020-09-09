using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        string nombre;
        string apellido;
        double dni;
        Enfermedad dolencia;
        string descripcionDolencia;

        public Paciente(string nombre, string apellido, double dni, Enfermedad dolencia, string descripcionDolencia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.dolencia = dolencia;
            this.descripcionDolencia = descripcionDolencia;
        }

       public void SetEnfermedad(Enfermedad dolencia)
        {
            this.dolencia = dolencia;
        }

       



    }
}
