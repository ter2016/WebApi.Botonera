using AutoMapper;
using WebApi.Botonera.Models;

namespace WebApi.Botonera.DTOs
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Defecto, DefectoDTO>().ReverseMap();
                cfg.CreateMap<EstacionTrabajoDefecto, EstacionTrabajoDefectoDTO>().ReverseMap();
            });
        }
    }
}
