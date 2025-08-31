using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Commands.CreateMusician
{
    public class CreateMusicianCommand : ICommand
    {
        public Guid? MusicianId { get; set; }
        public string Name { get; set; }
        public string Instrument { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
