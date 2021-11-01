using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models//LAS DECORACIONES SIEMPRE SE USA ANTES DE CADA PROPIEDAD
{
    [Table("Paciente")]//EF cuando crea la tabla la llama Paciente en singular, sino por convension pluraliza el nombre a "Pacientes"
    public class Paciente
    {        
        public int Id { get; set; }
        [Required]//Not null
        [Column(TypeName ="varchar")]//tipo de dato de SQL server
        [MaxLength(50)]//HASTA 50 CARACTERES
        public string Nombre { get; set; }
        [Required]//Not null
        [Column(TypeName = "varchar")]//tipo de dato de SQL server
        [MaxLength(50)]//HASTA 50 CARACTERES
        public string Apellido { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }
        public int NroHistoriaClinica { get; set; }

        public int MedicoId { get; set; }//FK clave externa
        //propiedad de navegacion
        [ForeignKey("MedicoId")]
        public Medico medico { get; set; }
    }
}
