using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;//AGREGAR ENTITY FRAMEWORK SINO NO FUNCIONA
using Datos.Models;//ver los modelos

namespace Datos.Data
{
    public class DbClinicaContext:DbContext
    {
        //constructor
        public DbClinicaContext() : base("KeyDbClinica") { }

        //propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }        
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
    }
}
