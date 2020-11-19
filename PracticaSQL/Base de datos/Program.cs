using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Base_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Persona> listaPersonas = new List<Persona>();
            //int dni;
            int id;
            string nombre = "chocolate";
            double precio = 62.87;
            
            SqlConnection miConexion = new SqlConnection();
            string path = "Data Source=.\\sqlexpress; Initial Catalog=Mensajeria; Integrated Security=True;";
            miConexion.ConnectionString = path;

            SqlCommand miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            //miComando.CommandText = "Select * From Valores";
            miConexion.Open();

            //SqlDataReader reader = miComando.ExecuteReader();

            //while (reader.Read())
            //{
            //    nombre = reader["descripcion"].ToString();
            //    double.TryParse(reader["valor"].ToString(), out precio);
            //    int.TryParse(reader["id"].ToString(), out id);
            //    //if (int.TryParse(reader["DNI"].ToString(), out dni) && int.TryParse(reader["Id"].ToString(), out id))
            //    //{
            //    //    listaPersonas.Add(new Persona(reader["Nombre"].ToString(), reader["Apellido"].ToString(), dni, id));
            //    //}
            //}

            //foreach (Persona pers in listaPersonas)
            //{
            //    Console.WriteLine(pers.ToString());
            //}

            //reader.Close();
            //string nombre = "hola";
            //float precio = 40;
            miComando.CommandText = $"INSERT INTO Valores(descripcion,valor)VALUES(@auxNombre, @auxPrecio)";
            miComando.Parameters.Add(new SqlParameter("@auxNombre", nombre));
            miComando.Parameters.Add(new SqlParameter("@auxPrecio", precio));
            if (miComando.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("Operacion exitosa");
            }


            Console.ReadKey();


        }
    }
}
