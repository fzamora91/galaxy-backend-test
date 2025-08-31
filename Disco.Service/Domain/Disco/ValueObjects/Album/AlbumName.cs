using Microsoft.EntityFrameworkCore;
using SharedKernel.Domain.ValueObjects;

namespace Disco.Service.Domain.Disco.ValueObjects.Album
{
    [Owned]
    public sealed class AlbumName : ValueObject
    {
        public string Value { get; }

        private AlbumName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Title cannot be empty.");

            if (value.Length > 200)
                throw new ArgumentException("Title cannot exceed 200 characters.");

            Value = value.Trim();
        }

        public static AlbumName Create(string value) => new(value);


        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value.ToLowerInvariant();
        }

        public override string ToString() => Value;


    }
}
