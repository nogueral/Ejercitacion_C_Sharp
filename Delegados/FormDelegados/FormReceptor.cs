using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDelegados
{
    public partial class FormReceptor : Form
    {
        public FormReceptor()
        {
            InitializeComponent();
        }

        public void MostrarMensaje(string texto)
        {
            this.txtmensajeRecibido.Text += texto;
        }

        public void ImprimirFecha(string texto)
        {
            MessageBox.Show(DateTime.Now.ToString() + " " + texto);

        }
    }
}
