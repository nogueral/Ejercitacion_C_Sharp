using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversor;

namespace FormConversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            int resultado = Conversor.Conversor.BinarioDecimal(this.txtNumero1.Text);

            this.lblNumero4.Text = resultado.ToString();
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            int numero;

            if(!int.TryParse(this.txtNumero2.Text, out numero))
            {
                numero = 0;
            }

            this.lblNumero3.Text = Conversor.Conversor.DecimalBinario(numero);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblNumero3.Text = "Resultado";
            this.lblNumero4.Text = "Resultado";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
