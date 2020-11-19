using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        string nombre;
        string apellido;
        double dni;
        int id;

        public Persona()
        {
            this.Id = 0;
        }

        public Persona(string nombre, string apellido, double dni) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public Persona(string nombre, string apellido, int dni, int id) : this(nombre, apellido, dni)
        {
            
            this.Id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Dni { get => dni; set => dni = value; }
        public int Id { get => id; set => id = value; }

        public bool Guardar()
        {
            return PersonaDAO.InsertarPersona(this);
        }

        public bool Eliminar()
        {
            return PersonaDAO.EliminarPersona(this);
        }

        public bool Modificar()
        {
            return PersonaDAO.ModificarPersona(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine("<----------------------------------->");

            return sb.ToString();
        }
    }
}
