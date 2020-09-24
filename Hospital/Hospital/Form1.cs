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

        public Medico MiMedico
        {
            get { return miMedico; }
            set { miMedico = value; }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            int dni;
            if (int.TryParse(this.txtDni.Text, out dni) && cbEspecialidad.SelectedIndex != -1)
            {
                miMedico = new Medico(this.txtNombre.Text, this.txtApellido.Text, dni, 
                (EEespecialidades)this.cbEspecialidad.SelectedItem);

                this.DialogResult = DialogResult.OK;

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Leandro Daniel";
            this.txtApellido.Text = "Noguera";
            this.txtDni.Text = "33252056";
            this.cbEspecialidad.DataSource = Enum.GetValues(typeof(EEespecialidades));
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            // Quita espacios izq y der
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

            // pasa todo el texto a minusculas
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            //convierte la 1er letra en mayuscula
            // concatena el resto del nombre
            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = String.Concat(Char.ToUpper(((TextBox)sender).Text[0]),
                ((TextBox)sender).Text.Substring(1));

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
            //((TextBox)sender).Text.Substring(1, 5);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
