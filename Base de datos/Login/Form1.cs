using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        List<Persona> lista;
        SqlConnection miConexion;
        SqlCommand comandito;
        public Form1()
        {
            InitializeComponent();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            lista = new List<Persona>();
            miConexion = new SqlConnection("Data Source=agasoluciones.dynamic-dns.net\\mssqlserver2; Initial Catalog = Mensajes; User Id=Alumno;Password=FraUtn;");
            comandito = new SqlCommand();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            comandito.Connection = miConexion;
            comandito.CommandType = CommandType.Text;
            comandito.CommandText = "SELECT * FROM Personas where Nombre like @auxNombre and Apellido like @auxPass";
            comandito.Parameters.Clear();
            comandito.Parameters.Add(new SqlParameter("@auxNombre", string.Concat('%', this.txtUsuario.Text, '%')));
            comandito.Parameters.Add(new SqlParameter("@auxPass", string.Concat('%', this.txtClave.Text, '%')));
            if (miConexion.State != ConnectionState.Open)
                miConexion.Open();
            SqlDataReader lector = comandito.ExecuteReader();
            DataTable auxDt = new DataTable();
            auxDt.Load(lector);
            DataView dv = new DataView(auxDt);
            while (lector.Read())
            {
                lista.Add(new Persona(int.Parse(lector["Id"].ToString()),
                                      lector["Nombre"].ToString(),
                                      lector["Apellido"].ToString(),
                                      int.Parse(lector["DNI"].ToString())));
            }
            //dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();
            //dataGridView1.DataSource = lista;
            miConexion.Close();
        }


        //public FormLogin()
        //{
        //    InitializeComponent();
        //}

        //private void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    SqlConnection miConexion = new SqlConnection("Data Source=agasoluciones.dynamic-dns.net\\mssqlserver2; Initial Catalog = Mensajes; User Id=Alumno;Password=FraUtn;");
        //    SqlCommand comandito = new SqlCommand();
        //    //comandito.Connection = new SqlConnection("Data Source=[agasoluciones.dynamic-dns.net\\mssqlserver2]; Initial Catalog = [Mensajes]; User Id=Alumno;Password=FraUtn;");
        //    comandito.Connection = miConexion;
        //    comandito.CommandType = CommandType.Text;
        //    comandito.CommandText = "SELECT * FROM Personas";
        //    //conecta al server
        //    miConexion.Open();
        //    SqlDataReader lector = comandito.ExecuteReader();
        //    string nombreAlumno;
        //    while (lector.Read())
        //    {
        //        nombreAlumno = lector["Nombre"].ToString();
        //    }

        //}
    }
}
