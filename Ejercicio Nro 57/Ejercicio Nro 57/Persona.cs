using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_Nro_57
{
    public class Persona
    {
        string nombre;
        string apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public static bool Guardar(Persona pers)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "persona.xml";

            if (pers != null)
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Persona));

                    ser.Serialize(writer, pers);

                    return true;
                }
            }

            return false;
        }

        public static Persona Leer()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "persona.xml";
            Persona pers = new Persona();

            using (XmlTextReader reader = new XmlTextReader(ruta))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));

                pers = (Persona)ser.Deserialize(reader);
            }

            return pers;
        }

        public override string ToString()
        {
            return String.Format($"Nombre: {this.Nombre} \nApellido: {this.apellido}");
        }
    }
}
