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
    public partial class FormLogIn : Form
    {
        string auxUser;

        public string AuxUser
        {
            get { return auxUser; }
        }

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            Inventario.HardcodeoUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validarUsuario = false;

            if(!Validar.ValidarString(this.txtUsuario.Text) && !Validar.ValidarString(this.txtClave.Text))
            {
                foreach (var item in Inventario.ListaUsuarios)
                {

                    if(item.Key == this.txtUsuario.Text)
                    {
                        if(item.Value == this.txtClave.Text)
                        {
                            validarUsuario = true;

                            auxUser = item.Key;

                            DialogResult = DialogResult.OK;
                        }
                    }
                }

                if (!validarUsuario)
                {
                    MessageBox.Show("Verifique clave o contraseña", Inventario.NombreComercio);
                }

               
            }
        }
    }
}
