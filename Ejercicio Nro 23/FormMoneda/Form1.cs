using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;
using System.Threading;

namespace FormMoneda
{
    
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(ActualizarReloj);
            t.Start();
        }

        public void ActualizarReloj()
        {
            if (this.lblDateTime.InvokeRequired)
            {
                this.lblDateTime.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lblDateTime.Text = DateTime.Now.ToString();
                });

            } else
            {
                this.lblDateTime.Text = DateTime.Now.ToString();
            }

            Thread.Sleep(1000);
            this.ActualizarReloj();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
