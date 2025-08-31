using SharedKernel.Application.UseCases.Interfaces;
using SharedKernel.Utils.UpdatePartial;

namespace Disco.Service.Application.UseCases.Musician.Commands.UpdatePartialMusician
{
    public class UpdatePartialMusicianCommand : ICommand
    {
        public UpdatePartialDelta Delta { get; set; }
    }
}
