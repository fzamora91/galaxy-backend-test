using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Queries.GetMusicianByMusicianId
{
    public class GetMusicianByMusicianIdQuery : IQuery
    {
        public Guid MusicianId { get; set; }
    }
}
