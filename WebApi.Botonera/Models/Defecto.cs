using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Botonera.Models
{
    public class Defecto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(7)]
        public string Clave { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }

        public ICollection<EstacionTrabajoDefecto> EstacionTrabajoDefecto { get; set; }

    }
}
