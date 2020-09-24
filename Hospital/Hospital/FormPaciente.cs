using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormPaciente : Form
    {
        private Paciente miPaciente;

        public Paciente MiPaciente
        {
            get { return miPaciente; }
            set { miPaciente = value; }
        }

        public FormPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni;

            if(int.TryParse(this.txtDni.Text, out dni))
            {
                this.miPaciente = new Paciente(this.txtNombre.Text, this.txtApellido.Text, 
                    dni, this.txtDolencia.Text);

                this.DialogResult = DialogResult.OK;
            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            // Quita espacios izq y der
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

            // pasa todo el texto a minusculas
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            //convierte la 1er letra en mayuscula
            // concatena el resto del nombre
            if (((TextBox)sender).Text.Length >= 2)
                ((TextBox)sender).Text = Char.ToUpper(((TextBox)sender).Text[0]) +
                ((TextBox)sender).Text.Substring(1);

            int posicion = 1;
            while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
            {
                posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);

                // Ana
                ((TextBox)sender).Text = String.Concat(
                    ((TextBox)sender).Text.Substring(0, posicion + 1),
                    //M
                    Char.ToUpper(((TextBox)sender).Text[posicion + 1]),
                    //aria
                    ((TextBox)sender).Text.Substring(posicion + 2));

                posicion++;
            }
        }


        private void FormPaciente_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Leandro Daniel";
            this.txtApellido.Text = "Noguera";
            this.txtDni.Text = "33252056";
            this.txtDolencia.Text = "Dolor de oido";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

             this.Close();

        }
    }
}
