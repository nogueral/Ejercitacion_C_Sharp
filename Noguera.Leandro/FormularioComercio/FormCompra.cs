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
    public partial class FormCompra : Form
    {
        List<Compra> listaCompras;
        double auxMontoTotal = 0;
        //Empleado auxEmpleado;

        #region Properties
        /// <summary>
        /// Getter monto total
        /// </summary>
        public double MontoTotal
        {
            get { return this.auxMontoTotal; }
        }

        /// <summary>
        /// Getter Lista de compras
        /// </summary>
        public List<Compra> ListaCompras
        {
            get { return this.listaCompras; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormCompra()
        {
            InitializeComponent();
            listaCompras = new List<Compra>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga inicial del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompraClienteExistente_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = Inventario.ListaProductos;

        }

        /// <summary>
        /// Carga actualizada de los datagridviews
        /// </summary>
        private void CargarDatagrid()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = Inventario.ListaProductos;
            this.dgvCompra.DataSource = null;
            this.dgvCompra.DataSource = this.listaCompras;
        }

        /// <summary>
        /// Al hacer doble click sobre una fila, elimina el elemento de la lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            string auxDescripcion = (string)dgvCompra.CurrentRow.Cells["Descripcion"].Value;
            double auxPrecio = (double)dgvCompra.CurrentRow.Cells["Precio"].Value;

            // recorre la lista y elimina el objeto

            for (int i = 0; i < listaCompras.Count; i++)
            {
                if (listaCompras[i].Descripcion == auxDescripcion)
                {
                    listaCompras.Remove(listaCompras[i]);
                    break;
                }
            }

            // elimina el valor del monto total

            auxMontoTotal -= auxPrecio;

            // recorre el listado de productos, y aumenta el stock del objeto eliminado

            for (int i = 0; i < Inventario.ListaProductos.Count; i++)
            {
                if (Inventario.ListaProductos[i].Descripcion == auxDescripcion)
                {
                    Inventario.ListaProductos[i].Stock += 1;
                }
            }

            // actualiza los datagridviews y el label que muestra el valor total

            CargarDatagrid();
            lblMontoTotal.Text = auxMontoTotal.ToString();
        }

        /// <summary>
        /// Al hacer doble click, agrega un producto a la lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            string auxDescripcion;
            double auxPrecio;
            int auxCantidad;


            if (int.TryParse(this.txtCantidad.Text, out auxCantidad))
            {
                auxDescripcion = (string)dgvProductos.CurrentRow.Cells["Descripcion"].Value;
                auxPrecio = (double)dgvProductos.CurrentRow.Cells["Precio"].Value;

                if (!Validar.CerosYnegativos(auxCantidad))
                {
                    if (Inventario.ValidarCantidad(auxDescripcion, auxCantidad))
                    {
                        //Carga la cantidad solicitada de productos a la lista

                        for (int i = 0; i < auxCantidad; i++)
                        {
                            listaCompras.Add(new Compra(auxDescripcion, auxPrecio));
                        }

                        // Recorre la lista de productos y cuando la encuentra, reduce el stock 

                        for (int i = 0; i < Inventario.ListaProductos.Count; i++)
                        {
                            if (auxDescripcion == Inventario.ListaProductos[i].Descripcion)
                            {
                                Inventario.ListaProductos[i].Stock -= auxCantidad;
                            }
                        }

                        // actualiza el monto total, los datagridviews y el monto mostrado a traves del label

                        auxMontoTotal += (auxPrecio * auxCantidad);
                        lblMontoTotal.Text = auxMontoTotal.ToString();
                        CargarDatagrid();

                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock del producto solicitados", Inventario.NombreComercio);
                    }

                } else
                {
                    MessageBox.Show("La cantidad no puede ser 0 ni un numero negativo", Inventario.NombreComercio);
                }

            } else
            {
                MessageBox.Show("Por favor, agregue cantidad antes de continuar", Inventario.NombreComercio);
            }

            this.txtCantidad.Clear();
        }

        /// <summary>
        /// Genera una nueva compra, con un cliente nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            

            if (auxMontoTotal > 0)
            {
                FormClienteNuevo auxClienteNuevo = new FormClienteNuevo();
                

                if (auxClienteNuevo.ShowDialog() == DialogResult.OK)
                {
                    if (Inventario.ValidarCliente(auxClienteNuevo.AuxCliente))
                    {
                        // Si el cliente es miembro de la familia Simpson, aplica descuento.

                        MessageBox.Show("Por ser miembros de la familia Simpson tiene un descuentos del 13%", Inventario.NombreComercio);
                        double descuento = (auxMontoTotal) * 13 / 100;
                        double montoOriginal = auxMontoTotal;
                        auxMontoTotal = montoOriginal - descuento;
                        MessageBox.Show(String.Format("Total compras: ${0:#,###.00}\n Descuentos (13%): S{1:#,###.00}\n Montos abonados: ${2:#,###.00}",
                       montoOriginal, descuento, auxMontoTotal), Inventario.NombreComercio);

                    }
                    else
                    {
                        MessageBox.Show(String.Format("Montos abonados: ${0:#,###.00}", auxMontoTotal), Inventario.NombreComercio);
                    }

                    //Agrega venta, a la lista de ventas 

                    Inventario.ListaVentas.Add(new Venta(auxClienteNuevo.AuxEmpleado, auxClienteNuevo.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun articulos para continuar con la compras!", Inventario.NombreComercio);
            }


        }

        /// <summary>
        /// Crea una nueva compra de un cliente existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            if (auxMontoTotal > 0)
            {
                FormClienteExistente auxClienteExistente = new FormClienteExistente();

                if (auxClienteExistente.ShowDialog() == DialogResult.OK)
                {
                    if (Inventario.ValidarCliente(auxClienteExistente.AuxCliente))
                    {
                        // si es miembro de la familia Simpson aplica descuento

                        MessageBox.Show("Por ser miembros de la familia Simpson tiene un descuentos del 13%", Inventario.NombreComercio);
                        double descuento = (auxMontoTotal) * 13 / 100;
                        double montoOriginal = auxMontoTotal;
                        auxMontoTotal = montoOriginal - descuento;
                        MessageBox.Show(String.Format("Total compras: ${0:#,###.00}\n Descuentos (13%): S{1:#,###.00}\n Montos abonados: ${2:#,###.00}",
                        montoOriginal, descuento, auxMontoTotal), Inventario.NombreComercio);

                    }
                    else
                    {
                        MessageBox.Show(String.Format("Montos abonados: ${0:#,###.00}", auxMontoTotal), Inventario.NombreComercio);
                    }

                    // Agrega venta a la lista de ventas 

                    Inventario.ListaVentas.Add(new Venta(auxClienteExistente.AuxEmpleado, auxClienteExistente.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun articulos para continuar con la compras!", Inventario.NombreComercio);
            }
        }

        /// <summary>
        /// Asigna el empleado logueado a la variable auxiliar
        /// </summary>
        /*private void AsignarEmpleado()
        {

            for (int i = 0; i < Inventario.GetListaEmpleados().Count; i++)
            {
                if (Inventario.GetListaEmpleados()[i].Usuario == Inventario.UsuarioActivo)
                {
                    auxEmpleado = Inventario.GetListaEmpleados()[i];
                }
            }


        }*/
        #endregion
    }
}
