using Disco.Service.Application.UseCases.Musician.Models;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Commands.DeleteMusician
{
    public class DeleteMusicianResult : ICommandResult
    {
        public MusicianModel? Musician { get; set; }
        public bool Success { get; set; }

        public DeleteMusicianResult()
        {
            Musician = new MusicianModel();
            Success = false;
        }
    }
}
