using Disco.Service.Domain.Disco.ValueObjects.Musician;
using SharedKernel.Domain.Interfaces;
using SharedKernel.Domain.Entities;
using System;
using System.Diagnostics.Metrics;

namespace Disco.Service.Domain.Disco.Entities
{
    public class Musician : AggregateRoot<Guid>
    {

        public Guid MusicianId => Id;
        public FullName Name { get; private set; }
        public string Instrument { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Country { get; private set; }
        public MusicGenre musicGenre { get; private set; }

        private readonly List<Album> _album = new();
        public IReadOnlyCollection<Album> Albums => _album.AsReadOnly();

        protected Musician() { }

        private Musician(Guid id, FullName name, string instrument, DateTime birthDate, string country,  MusicGenre musicGenre):base(id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            
            Instrument = instrument ?? throw new ArgumentNullException(nameof(instrument));

            BirthDate = birthDate;

            Country = country ?? throw new ArgumentNullException(nameof(country));

            musicGenre = musicGenre ?? throw new ArgumentNullException(nameof(musicGenre));
        }


        public static Musician Create(Guid? id, FullName name, string instrument, DateTime birthDate, string country, MusicGenre musicGenre)
        {
            if (id == null || id == Guid.Empty) id = Guid.NewGuid();

            return new Musician(id.Value, name, instrument, birthDate, country,  musicGenre);
        }

        public void AddAlbum(Album album)
        {
            if (_album.Any(b => b.Name == album.Name))
                throw new Exception(album.Name.Value);
            _album.Add(album);
        }

    }
}
