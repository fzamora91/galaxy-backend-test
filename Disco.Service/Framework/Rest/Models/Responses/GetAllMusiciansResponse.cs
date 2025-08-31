using Disco.Service.Framework.Rest.Models.Dtos;

namespace Disco.Service.Framework.Rest.Models.Responses
{
    public class GetAllMusiciansResponse
    {
        public List<MusicianDto> Data { get; set; } = new List<MusicianDto>();
    }
}
