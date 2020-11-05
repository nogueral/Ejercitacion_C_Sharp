using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string ruta, string dato)
        {
            if(!String.IsNullOrEmpty(ruta) && !String.IsNullOrEmpty(dato))
            {
                using (StreamWriter writer = new StreamWriter(ruta, false))
                {
                    writer.WriteLine(dato);
                    return true;
                }
            }

            return false;
        }

        public static string Leer(string ruta)
        {
            if (File.Exists(ruta))
            {
                using(StreamReader reader = new StreamReader(ruta))
                {
                    return reader.ReadToEnd();
               
                }

            } else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
