using System;

namespace WebApi.Botonera.DTOs
{
    public class EstacionTrabajoDefectoDTO
    {
        public int Id { get; set; }

        public string EstacionTrabajo { get; set; }

        public DateTime FechaRegsitro { get; set; }

        public int IdDefecto { get; set; }
        public DefectoDTO FK_EstacionTrabajoDefecto { get; set; }
    }
}
