using Comercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioComercio
{
    public partial class FormClienteExistente : Form
    {
        Cliente auxCliente;
        Empleado auxEmpleado;
        bool clickCliente = false;


        #region Properties
        /// <summary>
        /// Getter del objeto de tipo Cliente utilizado como auxiliar
        /// </summary>
        public Cliente AuxCliente
        {
            get { return this.auxCliente; }
        }

        /// <summary>
        /// Getter del objeto de tipo Empleadp utilizado como auxiliar
        /// </summary>
        public Empleado AuxEmpleado
        {
            get { return this.auxEmpleado; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormClienteExistente()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Cuando el usuario hace doble click sobre una fila, crea un objeto de tipo Cliente (lista de clientes existentes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            string nombre = (string)dgvCliente.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)dgvCliente.CurrentRow.Cells["Apellido"].Value;
            double dni = (double)dgvCliente.CurrentRow.Cells["Dni"].Value;

            auxCliente = new Cliente(nombre, apellido, dni);
            this.lblCliente.Text = String.Concat("Cliente: ", apellido, ", ", nombre);
            clickCliente = true;


        }

        /// <summary>
        /// Cuando el usuario hace doble click sobre una fila, crea un objeto de tipo Empleado (lista de empleados cargados)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            string nombre = (string)dgvEmpleado.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)dgvEmpleado.CurrentRow.Cells["Apellido"].Value;
            int idEmpleado = (int)dgvEmpleado.CurrentRow.Cells["IdEmpleado"].Value;
            string auxUsuario = (string)dgvEmpleado.CurrentRow.Cells["Usuario"].Value;

            auxEmpleado = new Empleado(nombre, apellido, idEmpleado, auxUsuario);
            this.lblEmpleado.Text = String.Concat("Empleado: ", apellido, ", ", nombre);

        }

        /// <summary>
        /// Carga inicial de los datagridviews
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClienteExistente_Load(object sender, EventArgs e)
        {
            CargarDatagrid();
        }

        /// <summary>
        /// Carga de listados a los correspondientes datagridviews
        /// </summary>
        private void CargarDatagrid()
        {
            this.dgvCliente.DataSource = null;
            this.dgvCliente.DataSource = Inventario.GetListaClientes();
            this.dgvEmpleado.DataSource = null;
            this.dgvEmpleado.DataSource = Inventario.GetListaEmpleados();
        }

        /// <summary>
        /// Si ambos objetos (Cliente y Empleado) fueron creados correctamente, se cargan a la compra y se finaliza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (clickCliente == true)
            {
                MessageBox.Show("Se agrego correctamente cliente la compras", Inventario.NombreComercio);
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Debe seleccionar todos los campos antes de continuar", Inventario.NombreComercio);
            }
        }
        #endregion

    }
}
