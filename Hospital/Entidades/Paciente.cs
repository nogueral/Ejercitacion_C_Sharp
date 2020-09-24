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

        public Paciente()
        {
            this.dolencia = new Enfermedad("A confirmar por el medico");
        }

        public Paciente(string nombre, string apellido, double dni, string descripcionDolencia):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.descripcionDolencia = descripcionDolencia;
        }

        public double Dni
        {
            get { return this.dni; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Dolencia
        {
            get { return this.descripcionDolencia; }
        }

        public void SetEnfermedad(Enfermedad dolencia)
        {
            this.dolencia = dolencia;
        }



       public static bool operator == (List<Paciente> listaPacientes, Paciente auxPaciente)
        {

            for (int i = 0; i < listaPacientes.Count; i++)
            {
                if(listaPacientes[i] != null && listaPacientes[i].Dni == auxPaciente.Dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(List<Paciente> listaPacientes, Paciente auxPaciente)
        {
            return !(listaPacientes == auxPaciente);
        }

    }
}
