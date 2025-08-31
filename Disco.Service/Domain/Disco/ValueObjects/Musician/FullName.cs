using SharedKernel.Domain.ValueObjects;

namespace Disco.Service.Domain.Disco.ValueObjects.Musician
{
    public sealed class FullName : ValueObject
    {
        public string FirstName { get; }
        public string LastName { get; }

        private FullName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name cannot be empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name cannot be empty.", nameof(lastName));

            FirstName = firstName.Trim();
            LastName = lastName.Trim();
        }

        public static FullName Create(string firstName, string lastName) =>
           new FullName(firstName, lastName);

        public override string ToString() => $"{FirstName} {LastName}";

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName.ToLowerInvariant();
            yield return LastName.ToLowerInvariant();
        }

    }
}
