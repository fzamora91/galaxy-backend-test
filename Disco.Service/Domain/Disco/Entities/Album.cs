using Disco.Service.Domain.Disco.ValueObjects.Album;
using SharedKernel.Domain.Entities;
using SharedKernel.Domain.Interfaces;

namespace Disco.Service.Domain.Disco.Entities
{
    public class Album : Entity<Guid>
    {

        public Guid MusicianId { get; private set; }

        public AlbumName Name { get; private set; }

        public DateTime ReleaseDate { get; private set; }

        public string Label { get; private set; }

        protected Album() { }


        private Album(Guid id, Guid musicianId, AlbumName name, DateTime relesase, string label)
            : base(id)
        {
            MusicianId = musicianId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ReleaseDate = relesase;
            Label = label;
        }

        public static Album Create(Guid id, Guid authorId, AlbumName name, DateTime relesase, string label)
        {
            return new Album(id, authorId, name, relesase, label);
        }


        public static Album Create(Guid id, Guid authorId, string name, DateTime relesase, string label)
        {
            return new Album(id, authorId, AlbumName.Create(name), relesase, label);
        }

    }
}
