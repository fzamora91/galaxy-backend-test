using Disco.Service.Application.UseCases.Musician.Models;

namespace Disco.Service.Application.Interfaces
{
    public interface IMusicianQueryService
    {
        Task<IEnumerable<MusicianModel>> GetAllMusiciansAsync();
        Task<MusicianModel?> GetMusicianByMusicianIdAsync(Guid authorId);
    }
}
