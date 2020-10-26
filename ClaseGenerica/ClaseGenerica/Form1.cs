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

            switch (this.cmbPpal.SelectedItem.ToString())
            {
                case "Productos":
                    ActualizarDatagridview<List<Producto>>(Inventario.ListaProductos);
                    break;
                case "Clientes":
                    ActualizarDatagridview<List<Cliente>>(Inventario.GetListaClientes());
                    break;
                case "Empleados":
                    ActualizarDatagridview<List<Empleado>>(Inventario.GetListaEmpleados());
                    break;

            }


        }

        private void ActualizarDatagridview<T> (T lista)
        {
            this.dgvPpal.DataSource = null;
            this.dgvPpal.DataSource = lista;
            this.dgvPpal.Refresh();
        }
    }
}
