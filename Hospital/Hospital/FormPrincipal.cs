using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormPrincipal : Form
    {
        Medico[] listaMedicos;
        List<Paciente> listaPacientes;


        public FormPrincipal()
        {
            InitializeComponent();
            listaMedicos = new Medico[1];
            listaPacientes = new List<Paciente>();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formularioMedico = new Form1();

            //formularioMedico.Show(); // Ejecuto y la app sigue corriendo
             if (formularioMedico.ShowDialog() == DialogResult.OK) // No sigue ejecutando hasta que no se cierre el form
              {
                  if(listaMedicos + formularioMedico.MiMedico)
                  {
                      MessageBox.Show("Se agrego correctamente", "Alta de Medico");
                  }
              }


        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("Esta seguro que desea salir?", "Huyendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaciente formularioPaciente = new FormPaciente();
            //formularioMedico.Show(); // Ejecuto y la app sigue corriendo
            if (formularioPaciente.ShowDialog() == DialogResult.OK) // No sigue ejecutando hasta que no se cierre el form
            {
                if(listaPacientes != formularioPaciente.MiPaciente)
                {
                    listaPacientes.Add(formularioPaciente.MiPaciente);
                    MessageBox.Show("Paciente cargado correctamente", "Carga de paciente");
                }
                
                
            }

            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargaInicial();
            CargarDatagridPacientes();
            
        }

        private void CargarDatagridPacientes()
        {
            this.dgvListaPacientes.DataSource = null;
            this.dgvListaPacientes.DataSource = listaPacientes;
            ConfigurarDatagrid();

        }

        private void ConfigurarDatagrid()
        {
            this.dgvListaPacientes.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvListaPacientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void CargaInicial()
        {
            listaPacientes.Add(new Paciente("leandro", "noguera", 33252056, "dolor de oido"));
            listaPacientes.Add(new Paciente("juan", "perez", 22222, "dolor de oido"));
            listaPacientes.Add(new Paciente("jose", "jose", 3333, "dolor de oido"));
            listaPacientes.Add(new Paciente("maria", "maria", 444, "dolor de oido"));
            listaPacientes.Add(new Paciente("gomez", "gomez", 55555, "dolor de oido"));
        }

        private void btnCargarMasPacientes_Click(object sender, EventArgs e)
        {
            listaPacientes.Add(new Paciente("leandro", "noguera", 33252056, "dolor de oido"));
            listaPacientes.Add(new Paciente("juan", "perez", 22222, "dolor de oido"));
            listaPacientes.Add(new Paciente("jose", "jose", 3333, "dolor de oido"));
            listaPacientes.Add(new Paciente("maria", "maria", 444, "dolor de oido"));
            listaPacientes.Add(new Paciente("gomez", "gomez", 55555, "dolor de oido"));
            
            CargarDatagridPacientes();
        }
    }
}
