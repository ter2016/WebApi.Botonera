using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Botonera.Models
{
    public class EstacionTrabajoDefecto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string EstacionTrabajo { get; set; }

        public DateTime FechaRegsitro{ get; set; }


        [ForeignKey("FK_EstacionTrabajoDefecto")]
        public int IdDefecto { get; set; }
        public Defecto FK_EstacionTrabajoDefecto { get; set; }


    }
}
