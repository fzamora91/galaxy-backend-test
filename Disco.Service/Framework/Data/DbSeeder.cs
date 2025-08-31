using Disco.Service.Domain.Disco.Interfaces;

namespace Disco.Service.Framework.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(IUnitOfWork unitOfWork)
        {
            await unitOfWork.MigrateAsync();
            if (await unitOfWork.Musician.AnyAsync())
            {
                return; // Database already seeded
            }

            await unitOfWork.Musician.AddAsync(DemoAuthorFactory.ArturoLopez());

            await unitOfWork.CompleteAsync();
        }
    }
}
