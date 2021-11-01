using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Models;
using Datos.Admin;


namespace WindowsEF
{
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            MostrarLista();
            LlenarCombo();
            LlenarFiltro();
        }

        private void LlenarCombo()
        {
            List<Especialidad> especialidades = AdmEspecialidad.Listar();
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "Nombre";
            cbEspecialidad.ValueMember = "Id";
        }
        private void LlenarFiltro()
        {
            List<Especialidad> especialidades = AdmEspecialidad.Listar();
            especialidades.Insert(0, new Especialidad()
            {
                Id = 0,
                Nombre = "[Todas]"
            });
            cbFiltro.DataSource = especialidades;
            cbFiltro.DisplayMember = "Nombre";
            cbFiltro.ValueMember = "Id";
        }

        private void MostrarLista()
        {
            gridMostrar.DataSource = AdmMedico.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Matricula = Convert.ToInt32(txtMatricula.Text),
                EspecialidadId = Convert.ToInt32(cbEspecialidad.SelectedValue)
            };
            int filasAfectadas = AdmMedico.Insertar(medico);
            if (filasAfectadas>0)
            {
                MostrarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Medico medicoModificado = new Medico()
            {
                MedicoId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido=txtApellido.Text,
                Matricula=Convert.ToInt32(txtMatricula.Text),
                EspecialidadId=Convert.ToInt32(cbEspecialidad.SelectedValue)
            };
            int filasAfectadas = AdmMedico.Modificar(medicoModificado);
            if (filasAfectadas>0)
            {
                MostrarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            int filasAfectadas = AdmMedico.Eliminar(id);

            if (filasAfectadas>0)
            {
                MostrarLista();
            }
        }

        private void cbFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int especialidad = Convert.ToInt32(cbFiltro.SelectedValue);
            if (especialidad == 0)
            {
                MostrarLista();
            }
            else
            {
                gridMostrar.DataSource = AdmMedico.ListarEspecialidadId(especialidad);
            }
        }
    }
}
