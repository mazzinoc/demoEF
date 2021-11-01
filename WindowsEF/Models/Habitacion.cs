using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(12)]
        public string Estado { get; set; }
        public int ClinicaId { get; set; }
        [ForeignKey("ClinicaId")]
        public Clinica clinica { get; set; }
    }
}
