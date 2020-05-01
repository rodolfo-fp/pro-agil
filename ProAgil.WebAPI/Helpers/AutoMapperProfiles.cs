using System.Linq;
using AutoMapper;
using ProAgil.Domain;
using ProAgil.WebAPI.Dtos;

namespace ProAgil.WebAPI.Helpers {
    public class AutoMapperProfiles : Profile {
        public AutoMapperProfiles() {
            CreateMap<Evento, EventoDto>()
                .ForMember(
                    dest => dest.Palestrantes, 
                    opt => { opt.MapFrom(src => src.PalestranteEventos.Select(x => x.Palestrante).ToList()); }
                );
            CreateMap<Lote, LoteDto>();
            CreateMap<Palestrante, PalestranteDto>()
                .ForMember(
                    dest => dest.Eventos,
                    opt => { opt.MapFrom(src => src.PalestranteEventos.Select(x => x.Evento).ToList()); }
                );
            CreateMap<RedeSocial, RedeSocialDto>();
        }
    }
}