using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApi.Botonera.DTOs
{
    public class DefectoDTO
    {
        public int Id { get; set; }

        public string Clave { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [JsonIgnore]
        public ICollection<EstacionTrabajoDefectoDTO> EstacionTrabajoDefecto { get; set; }
    }
}
