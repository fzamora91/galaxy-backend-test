using SharedKernel.Domain.ValueObjects;

namespace Disco.Service.Domain.Disco.ValueObjects.Musician
{
    public sealed class MusicGenre : ValueObject
    {

        public string Name { get; }

        private MusicGenre(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Genre cannot be empty.");

            Name = name.Trim();
        }

        public static MusicGenre Create(string name) => new(name);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name.ToLowerInvariant();
        }

        public override string ToString() => Name;
    }
}
