using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Hospital
{
    public partial class Form1 : Form
    {
        private Medico miMedico;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            int dni;
            if (int.TryParse(this.txtDni.Text, out dni) && cbEspecialidad.SelectedIndex != -1) 
            miMedico = new Medico(this.txtNombre.Text, this.txtApellido.Text, dni,this.cbEspecialidad.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Leandro";
            this.txtApellido.Text = "Noguera";
            this.txtDni.Text = "33252056";
        }
    }
}
