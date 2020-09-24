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

    public partial class FormClienteNuevo : Form
    {
        Cliente auxCliente;
        Empleado auxEmpleado;
        bool cargaEmpleado = false;

        #region Properties
        /// <summary>
        /// Getter del objeto de tipo Cliente utilizado como auxiliar
        /// </summary>
        public Cliente AuxCliente
        {
            get { return auxCliente; }
        }

        /// <summary>
        /// Getter del objeto de tipo Empleado utilizado como auxiliar
        /// </summary>
        public Empleado AuxEmpleado
        {
            get { return auxEmpleado; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Contructor
        /// </summary>
        public FormClienteNuevo()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida todos los datos ingresados y, si son correctos, crea un objeto de tipo Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            double dni;


            if (!Validar.ValidarString(this.txtApellido.Text) && !Validar.ValidarString(this.txtNombre.Text) && 
                double.TryParse(this.txtDni.Text, out dni))
            {
                if (!Validar.CerosYnegativos(dni))
                {
                    auxCliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text, dni);

                    if (Inventario.GetListaClientes() != auxCliente)
                    {
                        // Si el cliente no esta cargado en la lista de clientes existentes, lo agrega

                        Inventario.ListaPersonas.Add(auxCliente);
                        MessageBox.Show("Cliente cargados con exito!", Inventario.NombreComercio);

                    }
                    else
                    {
                        MessageBox.Show("Cliente registrados previamentes, los datos no seran duplicados!", Inventario.NombreComercio);

                    }

                    DialogResult = DialogResult.OK;

                } else
                {
                    MessageBox.Show("Verificar DNI", Inventario.NombreComercio);
                }

            } else
            {
                MessageBox.Show("Verifique los datos ingresados antes de continuar", Inventario.NombreComercio);
            }
        }

        /// <summary>
        /// Cuando el usuario abandona el textbox, automaticamente se pasan a minuscula las letras y a mayuscula iniciales de nombres y apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = String.Concat(Char.ToUpper(((TextBox)sender).Text[0]), ((TextBox)sender).Text.Substring(1));

                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {
                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(((TextBox)sender).Text.Substring(0, posicion + 1),
                    Char.ToUpper(((TextBox)sender).Text[posicion + 1]), ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }
            }
        }

        /// <summary>
        /// Carga inicial de la lista de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClienteNuevo_Load(object sender, EventArgs e)
        {
            CargarDatagrid();
        }

        /// <summary>
        /// Agrega la lista de referencia al datagridview
        /// </summary>
        private void CargarDatagrid()
        {
            this.dgvListaEmpleados.DataSource = null;
            this.dgvListaEmpleados.DataSource = Inventario.GetListaEmpleados();
        }

        /// <summary>
        /// Cuando el usuario hacer doble click en alguna fila del datagridview, se crea un objeto de tipo Empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string auxApellido;
            string auxNombre;
            int auxID;
            string auxUsuario;

            auxApellido = (string)dgvListaEmpleados.CurrentRow.Cells["Apellido"].Value;
            auxNombre = (string)dgvListaEmpleados.CurrentRow.Cells["Nombre"].Value;
            auxID = (int)dgvListaEmpleados.CurrentRow.Cells["IdEmpleado"].Value;
            auxUsuario = (string)dgvListaEmpleados.CurrentRow.Cells["Usuario"].Value;

            auxEmpleado = new Empleado(auxNombre, auxApellido, auxID, auxUsuario);

            this.lblInfoEmpleado.Text = String.Concat(auxNombre, " ", auxApellido);
            
            cargaEmpleado = true;
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
