using AutoMapper;
using Disco.Service.Application.Interfaces;
using Disco.Service.Application.UseCases.Musician.Models;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians
{
    public class GetAllMusicianUseCase : IQueryUseCase<GetAllMusiciansQuery, GetAllMusiciansResult>
    {
        private readonly IMusicianQueryService _musicianQueryService;
        private readonly IMapper _mapper;


        public GetAllMusicianUseCase(IMusicianQueryService musicianQueryService, IMapper mapper)
        {
            _musicianQueryService = musicianQueryService;
            _mapper = mapper;
        }
        public async Task<GetAllMusiciansResult> ExecuteAsync(GetAllMusiciansQuery query)
        {
            var musicians = await _musicianQueryService.GetAllMusiciansAsync();
            var result = _mapper.Map<IEnumerable<MusicianModel>, GetAllMusiciansResult>(musicians);

            return result;
        }
    }
}
