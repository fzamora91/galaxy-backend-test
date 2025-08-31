using SharedKernel.Application.Interfaces;

namespace Disco.Service.Domain.Disco.Interfaces
{
    public interface IUnitOfWork : IGenericUnitOfWork
    {
        IMusicianRepository Musician { get; }
    }
}
