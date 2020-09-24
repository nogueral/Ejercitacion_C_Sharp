using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EEespecialidades
    {
        Pediatria,
        Traumatologia,
        Psiquiatria,
        Neonatologia
    }

    public class Medico
    {
        string nombre;
        string apellido;
        double dni;
        EEespecialidades especialidad;

        public Medico(string nombre, string apellido, double dni, EEespecialidades especialidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.especialidad = especialidad;
        }

        public static bool operator +(Medico[] listaMedicos, Medico auxMedico)
        {
            
            bool retorno = false;

            // recorro buscando libres

            for (int i = 0; i < listaMedicos.Length; i++)
            {
                if (listaMedicos[i] == null)
                {
                    listaMedicos[i] = auxMedico;
                    retorno = true;
                    break;
                }
            }

            // si no encontro, agrega un lugar

            if (retorno == false)
            {
                Array.Resize<Medico>(ref listaMedicos, listaMedicos.Length + 1);
                listaMedicos[listaMedicos.Length - 1] = auxMedico;
                retorno = true;
            }
               

            return retorno;
        }


    }


}
