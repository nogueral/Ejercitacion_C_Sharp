using ClaseGenerica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercio;

namespace ClaseGenerica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int minimo;
            int maximo;
            int valor;

            int.TryParse(this.txtMinimo.Text, out minimo);
            int.TryParse(this.txtMaximo.Text, out maximo);
            int.TryParse(this.txtValorAValidar.Text, out valor);

            if (Validaciones<int>.validarValor(minimo, maximo, valor))
            {
                this.lblResultado.Text = valor.ToString();

            }
            else
            {
                this.lblResultado.Text = "El valor esta fuera de los parametros establecidos";
                this.txtValorAValidar.Text = "";
            }




        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormABM<ProductoPerecedero> obj = new FormABM<ProductoPerecedero>(new ProductoPerecedero("Leche", 18, 82.30, 43, Producto.ETipo.perecedero));
            obj.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 auxForm = new Form2();
            auxForm.Show();
        }
    }
}
