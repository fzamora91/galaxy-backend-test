using Disco.Service.Application.UseCases.Musician.Models;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians
{
    public class GetAllMusiciansResult : IQueryResult
    {
        public IEnumerable<MusicianModel> Musicians { get; set; }
    }
}
