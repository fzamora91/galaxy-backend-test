using Disco.Service.Domain.Disco.Interfaces;

namespace Disco.Service.Framework.Data
{
    public static class SeederExtensions
    {
        public static async Task SeedDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var _unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

            await DbSeeder.SeedAsync(_unitOfWork);
        }
    }
}
