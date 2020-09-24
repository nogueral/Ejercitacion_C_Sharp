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

namespace FormularioComercio
{
    public partial class FormPrincipal : Form
    {

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Crea un formulario producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducto_Click(object sender, EventArgs e)
        {
            formProducto auxProducto = new formProducto();

            auxProducto.Show();
        }

        /// <summary>
        /// Carga inicial de clientes, empleados, productos y compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioComercio_Load(object sender, EventArgs e)
        {
            Inventario.HardcodeoClientes();
            Inventario.HardcodeoEmpleados();
            Inventario.HardcodeoProductos();
           // Inventario.HardcodeoCompras();

            FormLogIn auxLogin = new FormLogIn();

            if (auxLogin.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Login exitoso", Inventario.NombreComercio);

                Inventario.UsuarioActivo = auxLogin.AuxUser;
            }
            
        }

        /// <summary>
        /// Crea un formulario que muestra el stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock auxStock = new FormStock();

            auxStock.Show();
        }

        /// <summary>
        /// Crea un formulario que muestra el listado de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVentas auxFormVentas = new FormVentas();

            auxFormVentas.Show();
        }

        /// <summary>
        /// Crea un formulario de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompra_Click(object sender, EventArgs e)
        {
            FormCompra auxFormClienteExistente = new FormCompra();

            if (auxFormClienteExistente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!! Vuelva prontosss", "Kwik E Mart");
            }
        }
        #endregion
    }
}
