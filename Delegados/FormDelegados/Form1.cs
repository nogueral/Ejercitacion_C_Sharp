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
    public delegate string DelegadoParaMensaje(string texto);

    public partial class FormPrincipal : Form
    {
        public DelegadoParaMensaje probandoDelegado;

        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            probandoDelegado += EjemploTeorico;
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {

            bool salida = false;

            foreach (Form item in this.MdiChildren)
            {
                if(item is FormEmisor)
                {
                    salida = true;
                }

            }

            if (salida == false)
            {
                FormEmisor emisor = new FormEmisor();
                emisor.MdiParent = this;

                foreach (Form item in this.MdiChildren)
                {
                    if (item is FormReceptor)
                    {
                        emisor.enviarMensaje += ((FormReceptor)item).MostrarMensaje;
                        emisor.enviarMensaje += ((FormReceptor)item).ImprimirFecha;
                    }
                }

                emisor.Show();
            }

        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            bool salida = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item is FormReceptor)
                {
                    salida = true;
                }

            }

            if (!salida)
            {
                FormReceptor receptor = new FormReceptor();
                receptor.MdiParent = this;

                foreach (Form item in this.MdiChildren)
                {
                    if (item is FormEmisor)
                    {
                        ((FormEmisor)item).enviarMensaje += receptor.MostrarMensaje;
                        ((FormEmisor)item).enviarMensaje += receptor.ImprimirFecha;
                    }
                }

                    receptor.Show();
            }
        }

        public string EjemploTeorico(string param)
        {
            return param;
        }
    }
}
