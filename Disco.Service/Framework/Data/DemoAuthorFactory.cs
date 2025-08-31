using Disco.Service.Domain.Disco.Entities;
using Disco.Service.Domain.Disco.ValueObjects.Album;
using Disco.Service.Domain.Disco.ValueObjects.Musician;
using System;

namespace Disco.Service.Framework.Data
{
    internal static class DemoAuthorFactory
    {

        internal static Musician ArturoLopez()
        {
            var muscian = Musician.Create(
                Guid.Parse("f002d6b9-c6aa-4d74-af3b-2820ae96250c"),
                FullName.Create("Arturo", "Lopez"), 
                "Guitar", 
                new DateTime(1936, 3, 28), 
                "Mexico", 
                MusicGenre.Create("Salsa"));

            var albums = new List<Album>
            {
                Album.Create(
                    Guid.Parse("a3ca7a68-b077-4f42-9a8d-5aa5e135ee08"),
                    muscian.Id,
                    AlbumName.Create("Test1"),
                    new DateTime(1936, 3, 28),
                    "label test."
                ),
                Album.Create(
                    Guid.Parse("a3b0c442-98fc-1c14-9af2-2c5a7f6c2d8e"),
                    muscian.Id,
                    AlbumName.Create("Test2"),
                    new DateTime(1936, 3, 28),
                    "label test."
                )
            };
            albums.ForEach(muscian.AddAlbum);
            return muscian;
        }
    }
}
