using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FormCentralita
{
    public partial class formPrincipal : Form
    {
        Centralita centralita;
        public formPrincipal()
        {
            InitializeComponent();
            centralita = new Centralita("Central de llamadas");
        }
    }
}
