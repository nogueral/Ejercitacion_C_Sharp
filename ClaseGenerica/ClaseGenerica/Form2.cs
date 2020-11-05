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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ActualizarDatagridview<T>(T lista)
        {
            this.dgvPpal.DataSource = null;
            this.dgvPpal.DataSource = lista;
            this.dgvPpal.Refresh();
        }

        private void cmbPpal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbPpal.SelectedItem.ToString())
            {
                case "Productos":
                    Inventario.HardcodeoProductosPerecederos();
                    ActualizarDatagridview<List<Producto>>(Inventario.ListaProductos);
                    break;
                case "Clientes":
                    Inventario.HardcodeoClientes();
                    ActualizarDatagridview<List<Cliente>>(Inventario.GetListaClientes());
                    break;
                case "Empleados":
                    Inventario.HardcodeoEmpleados();
                    ActualizarDatagridview<List<Empleado>>(Inventario.GetListaEmpleados());
                    break;

            }
        }
    }
}
