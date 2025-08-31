using Disco.Service.Application.UseCases.Musician.Models;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Commands.UpdatePartialMusician
{
    public class UpdatePartialMusicianResult : ICommandResult
    {
        public MusicianModel? Musician { get; set; }
        public bool Success { get; set; }

        public UpdatePartialMusicianResult()
        {
            Musician = new MusicianModel();
            Success = false;
        }
    }
}
