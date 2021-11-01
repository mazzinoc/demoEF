using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Especialidad")]
    public class Especialidad
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Medico> medicos { get; set; }
    }
}
