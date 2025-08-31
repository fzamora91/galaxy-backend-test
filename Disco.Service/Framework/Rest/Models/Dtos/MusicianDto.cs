namespace Disco.Service.Framework.Rest.Models.Dtos
{
    public class MusicianDto
    {
        public Guid AuthorId { get; set; }
        public string FullName { get; set; }
        public string Instrument { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
