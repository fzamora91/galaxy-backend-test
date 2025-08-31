using Disco.Service.Application.UseCases.Musician.Commands.CreateMusician;
using Disco.Service.Application.UseCases.Musician.Commands.DeleteMusician;
using Disco.Service.Application.UseCases.Musician.Commands.UpdatePartialMusician;
using Disco.Service.Application.UseCases.Musician.Commands.UpsertMusician;
using Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians;
using Disco.Service.Application.UseCases.Musician.Queries.GetMusicianByMusicianId;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Interfaces
{
    public interface IMusicianApplicationService
    {
        IQueryUseCase<GetAllMusiciansQuery, GetAllMusiciansResult> GetAllMusiciansUseCase { get; }
        ICommandUseCase<CreateMusicianCommand, CreateMusicianResult> CreateMusicianUseCase { get; }
        IQueryUseCase<GetMusicianByMusicianIdQuery, GetMusicianByMusicianIdResult> GetMusicianByMusicianIdUseCase { get; }
        ICommandUseCase<UpsertMusicianCommand, UpsertMusicianResult> UpsertMusicianUseCase { get; }
        ICommandUseCase<UpdatePartialMusicianCommand, UpdatePartialMusicianResult> UpdatePartialMusicianUseCase { get; }
        ICommandUseCase<DeleteMusicianCommand, DeleteMusicianResult> DeleteMusicianUseCase { get; }

    }
}
