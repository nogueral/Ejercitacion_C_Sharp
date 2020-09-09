using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FormularioPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.tbNumero1.Text);
            int num2 = int.Parse(this.tbNumero2.Text);

            this.lblResultado.Text = (num1 + num2).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.tbNumero1.Text);
            int num2 = int.Parse(this.tbNumero2.Text);

            this.lblResultado.Text = (num1 - num2).ToString();
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            int num1, num2;

            int.TryParse(this.tbNumero1.Text, out num1);
            int.TryParse(this.tbNumero2.Text, out num2);

            this.lblResultado.Text = (num1 * num2).ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1, num2;

            int.TryParse(this.tbNumero1.Text, out num1);
            int.TryParse(this.tbNumero2.Text, out num2);

            this.lblResultado.Text = (num1 / num2).ToString();
        }
    }
}
