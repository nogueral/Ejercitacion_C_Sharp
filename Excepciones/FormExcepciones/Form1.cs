using MiExcepcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            try
            {
                throw new LeandroException("Excepcion personalizada");
            }
            catch (LeandroException ex)
            {

                MessageBox.Show(ex.Message);

                this.Cerrar();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

                this.Cerrar();
            }
        }

        private void Cerrar()
        {
            this.Close();
        }
    }
}
