using AutoMapper;
using Disco.Service.Application.UseCases.Musician.Commands.CreateMusician;
using Disco.Service.Application.UseCases.Musician.Commands.DeleteMusician;
using Disco.Service.Application.UseCases.Musician.Commands.UpdatePartialMusician;
using Disco.Service.Application.UseCases.Musician.Commands.UpsertMusician;
using Disco.Service.Application.UseCases.Musician.Models;
using Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians;
using Disco.Service.Application.UseCases.Musician.Queries.GetMusicianByMusicianId;
using SharedKernel.Utils;
using Entities = Disco.Service.Domain.Disco.Entities;


namespace Disco.Service.Application.UseCases.Musician.Mappings
{
    public class MusicianProfile : Profile
    {
        public MusicianProfile()
        {
            CreateMap<Entities.Musician, MusicianModel>()
                .ForMember(dest => dest.Instrument, opt => opt.MapFrom(src => src.Instrument.ToString()))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name.ToString()))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country.ToString()))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToString()));

            CreateMap<List<MusicianModel>, GetAllMusiciansResult>().ForMember(dest => dest.Musicians, opt => opt.MapFrom(src => src));
            CreateMap<MusicianModel, GetMusicianByMusicianIdResult>();
            CreateMap<Entities.Musician, CreateMusicianResult>().IncludeBase<Entities.Musician, MusicianModel>();
            CreateMap<Entities.Musician, UpsertMusicianResult>().ForMember(dest => dest.Musician, opt => opt.MapFrom(src => src));
            CreateMap<Entities.Musician, UpdatePartialMusicianResult>().ForMember(dest => dest.Musician, opt => opt.MapFrom(src => src));
            CreateMap<Entities.Musician, DeleteMusicianResult>().ForMember(dest => dest.Musician, opt => opt.MapFrom(src => src));
        }
    }
}
