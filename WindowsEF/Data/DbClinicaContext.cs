using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;//AGREGAR ENTITY FRAMEWORK SINO NO FUNCIONA
using WindowsEF.Models;//ver los modelos

namespace WindowsEF.Data
{
    public class DbClinicaContext:DbContext
    {
        //constructor
        public DbClinicaContext() : base("KeyDbClinica") { }

        //propiedades DbSet<m>
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Clinica> clinicas { get; set; }
        public DbSet<Habitacion> habitaciones { get; set; }
        public DbSet<Medico> medicos { get; set; }
        public DbSet<Especialidad> especialidades { get; set; }
    }
}
