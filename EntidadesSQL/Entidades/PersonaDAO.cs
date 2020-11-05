using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PersonaDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static PersonaDAO()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=Mensajeria; Integrated Security=True;";
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public static bool EjecutarNonQuery(string sql)
        {
            bool ejecuto = false;
            try
            {
                comando.CommandText = sql;
                conexion.Open();
                comando.ExecuteNonQuery();
                ejecuto = true;
            }
            catch (Exception e)
            {
                ejecuto = false;
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return ejecuto;
        }

        public static bool InsertarPersona(Persona pers)
        {
            string sql = String.Concat("Insert into Personas(Nombre, Apellido, DNi) values(","'", pers.Nombre, "', ", "'", pers.Apellido, "', ", pers.Dni.ToString(), ")");

            return EjecutarNonQuery(sql);
        }

        public static bool ModificarPersona(Persona pers)
        {
            
            string sql = "Update Personas set Nombre = " + "'" + pers.Nombre + "', Apellido = '" + pers.Apellido + "', DNi = " + pers.Dni.ToString() + "where id = " + pers.Id.ToString();

            return EjecutarNonQuery(sql);
        }

        public static bool EliminarPersona(Persona pers)
        {
            string sql = String.Concat("Delete Personas where id = ", pers.Id.ToString());

            return EjecutarNonQuery(sql);
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                comando.CommandText = "Select * from Personas";
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    personas.Add(new Persona(reader["Nombre"].ToString(), reader["Apellido"].ToString(), int.Parse(reader["DNi"].ToString()), int.Parse(reader["id"].ToString())));
                }

                reader.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return personas;
        }

        public static Persona LeerPorID(int id)
        {
            Persona pers = null;

            try
            {
                comando.CommandText = "Select * from Personas where id = " + id.ToString();
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    pers = new Persona(reader["Nombre"].ToString(), reader["Apellido"].ToString(), int.Parse(reader["DNi"].ToString()), id);
                }


                reader.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return pers;
        }
            
    }
}
