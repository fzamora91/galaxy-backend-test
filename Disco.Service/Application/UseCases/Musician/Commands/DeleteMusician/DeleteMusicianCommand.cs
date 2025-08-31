using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Commands.DeleteMusician
{
    public class DeleteMusicianCommand : ICommand
    {
        public Guid MusicianId { get; set; }
    }
}
