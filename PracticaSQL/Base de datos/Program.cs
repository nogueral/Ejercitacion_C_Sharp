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
            List<Persona> listaPersonas = new List<Persona>();
            int dni;
            int id;

            SqlConnection miConexion = new SqlConnection();
            string path = "Data Source=agasoluciones.dynamic-dns.net\\mssqlserver2; Initial Catalog = Mensajes; User Id=Alumno;Password=FraUtn;";
            miConexion.ConnectionString = path;

            SqlCommand miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "Select * From Personas where id > 10 and id < 20";
            miConexion.Open();

            //SqlDataReader reader = miComando.ExecuteReader();

            //while (reader.Read())
            //{
            //    if (int.TryParse(reader["DNI"].ToString(), out dni) && int.TryParse(reader["Id"].ToString(), out id))
            //    {
            //        listaPersonas.Add(new Persona(reader["Nombre"].ToString(), reader["Apellido"].ToString(), dni, id));
            //    }
            //}

            //foreach (Persona pers in listaPersonas)
            //{
            //    Console.WriteLine(pers.ToString());
            //}

            //reader.Close();

            miComando.CommandText = "Update Personas set DNI = 22222 where id = 52";
            if (miComando.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("Operacion exitosa");
            }


            Console.ReadKey();


        }
    }
}
