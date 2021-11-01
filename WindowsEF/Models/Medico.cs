using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }

        //propiedad de navegacion
        public List<Paciente> pacientes { get; set; }
        public int EspecialidadId { get; set; }
        [ForeignKey("EspecialidadId")]
        public Especialidad especialidad { get; set; }
    }
}
