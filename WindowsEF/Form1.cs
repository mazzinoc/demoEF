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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            gridMostrar.DataSource = AdmPaciente.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {
                Nombre = "Juan",
                Apellido = "Fernandez",
                FechaNacimiento = new DateTime(2000, 1, 20),
                NroHistoriaClinica = 1111,
                MedicoId = 1
            };
            int filasAfectadas = AdmPaciente.Insertar(paciente);
            if (filasAfectadas>0)
            {
                MostrarPacientes();
            }
        }
    }
}
