using Disco.Service.Application.UseCases.Musician.Models;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Commands.UpsertMusician
{
    public class UpsertMusicianResult : ICommandResult
    {
        public bool IsCreated { get; set; }
        public MusicianModel? Musician { get; set; }
        public bool Success { get; set; }

        public UpsertMusicianResult()
        {
            Musician = new MusicianModel();
            IsCreated = false;
            Success = false;
        }
    }
}
