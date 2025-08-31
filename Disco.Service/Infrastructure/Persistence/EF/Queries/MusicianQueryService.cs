using Infrastructure.Persistences.EF.Relational.Generic.Repositories;
using Disco.Service.Application.Interfaces;
using Disco.Service.Domain.Disco.Entities;
using Disco.Service.Infrastructure.Persistence.EF.Contexts;
using Disco.Service.Application.UseCases.Musician.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Disco.Service.Infrastructure.Persistence.EF.Queries
{
    public class MusicianQueryService: QueryService<Musician, DiscoDbContext>, IMusicianQueryService
    {
        public MusicianQueryService(DiscoDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<MusicianModel>> GetAllMusiciansAsync()
        {
            return await _context.Musicians
                .AsNoTracking()
                .Select(a => new MusicianModel
                {
                    AuthorId = a.Id,
                    FullName = a.Name.ToString(),
                    Instrument = a.Instrument.ToString(),
                    Country = a.Country.ToString(),
                    BirthDate = a.BirthDate
                })
                .ToListAsync();
        }

        public async Task<MusicianModel?> GetMusicianByMusicianIdAsync(Guid musicianId)
        {
            return await _context.Musicians
                .AsNoTracking()
                .Where(a => a.Id == musicianId)
                .Select(a => new MusicianModel
                {
                    AuthorId = a.Id,
                    FullName = a.Name.ToString(),
                    Instrument = a.Instrument.ToString(),
                    Country = a.Country.ToString(),
                    BirthDate = a.BirthDate
                })
                .FirstOrDefaultAsync();
        }
    }
}
