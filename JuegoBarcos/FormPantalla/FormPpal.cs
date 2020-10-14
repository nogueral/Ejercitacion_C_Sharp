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

namespace FormPantalla
{
    public partial class FormPpal : Form
    {
        List<Barco> listaBarcos;
        Random auxRandom;
        bool mostrarBarcos = false;
        int ciclo=0;

        public FormPpal()
        {
            InitializeComponent();
            listaBarcos = new List<Barco>();
            auxRandom = new Random();
            Barco.XMax = this.Width;
            Barco.YMax = this.Height;
            this.timer1.Interval = 200;
            this.timer1.Enabled = true;
            this.mostrarBarcos = true;
        }

        private Barco NuevoBarco(bool amigo)
        {
            
            var largo = auxRandom.Next(1, 25);
            var ancho = auxRandom.Next(1, 25);

            if (amigo)
            {
                return new BarcoAmigo(auxRandom.Next(0, this.Width - largo - ancho), auxRandom.Next(0, this.Height - largo - ancho), largo, ancho);

            } else
            {
                return new BarcoEnemigo(auxRandom.Next(0, this.Width - largo - ancho), auxRandom.Next(0, this.Height - largo - ancho), largo, ancho);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Barco item in listaBarcos)
            {
                item.Mover();
            }

            this.Refresh();
            this.mostrarBarcos = (ciclo >= 0);

            if(ciclo > -2)
            ciclo--;
        }

        public void MostrarBarcos()
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            listaBarcos.Add(NuevoBarco(true));
            listaBarcos.Add(NuevoBarco(false));
            listaBarcos.Add(NuevoBarco(true));
            listaBarcos.Add(NuevoBarco(false));
            listaBarcos.Add(NuevoBarco(true));
            listaBarcos.Add(NuevoBarco(false));
            listaBarcos.Add(NuevoBarco(true));
            listaBarcos.Add(NuevoBarco(false));
            listaBarcos.Add(NuevoBarco(true));
            listaBarcos.Add(NuevoBarco(false));

            this.btnComenzar.Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ciclo = 3;
            this.Verificar(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
            
        }

        private void Verificar(int x, int y)
        {
            Barco barcoTocado = null;

            foreach (Barco item in listaBarcos)
            {
                if (item.ValidarPunto(x, y) != 0)
                {
                    barcoTocado = item;
                }
            }

            if (barcoTocado != null)
            {
                listaBarcos.Remove(barcoTocado);
            }
        }

        private void FormPpal_Paint(object sender, PaintEventArgs e)
        {
            Pen lapizVerde = new Pen(Color.Green, 5);
            Pen lapizRojo = new Pen(Color.Red, 5);

            if (this.mostrarBarcos)
            {
                foreach (Barco item in listaBarcos)
                {
                    if(item is BarcoAmigo)
                    {
                        e.Graphics.DrawRectangle(lapizVerde, item.PosicionX, item.PosicionY, item.Largo, item.Ancho);

                    } else
                    {
                        e.Graphics.DrawRectangle(lapizRojo, item.PosicionX, item.PosicionY, item.Largo, item.Ancho);
                    }

                    
                }

            }
        }
    }
}
