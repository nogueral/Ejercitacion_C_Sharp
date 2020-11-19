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
    public delegate void DelegadoMensaje(string mensaje);

    public partial class FormEmisor : Form
    {
        public event DelegadoMensaje enviarMensaje;

        public FormEmisor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!(enviarMensaje is null))
            enviarMensaje.Invoke(this.txtmensaje.Text);
        }
    }
}
