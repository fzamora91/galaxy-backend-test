using Disco.Service.Application.UseCases.Musician.Commands.CreateMusician;
using Disco.Service.Application.UseCases.Musician.Commands.DeleteMusician;
using Disco.Service.Application.UseCases.Musician.Commands.UpdatePartialMusician;
using Disco.Service.Application.UseCases.Musician.Commands.UpsertMusician;
using Disco.Service.Application.UseCases.Musician.Interfaces;
using Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians;
using Disco.Service.Application.UseCases.Musician.Queries.GetMusicianByMusicianId;
using SharedKernel.Application.UseCases.Interfaces;

namespace Disco.Service.Application.UseCases.Musician.Services
{
    public class MusicianApplicationService : IMusicianApplicationService
    {
        public IQueryUseCase<GetAllMusiciansQuery, GetAllMusiciansResult> GetAllMusiciansUseCase { get; }
        public ICommandUseCase<CreateMusicianCommand, CreateMusicianResult> CreateMusicianUseCase { get; }
        public IQueryUseCase<GetMusicianByMusicianIdQuery, GetMusicianByMusicianIdResult> GetMusicianByMusicianIdUseCase { get; }
        public ICommandUseCase<UpsertMusicianCommand, UpsertMusicianResult> UpsertMusicianUseCase { get; }
        public ICommandUseCase<UpdatePartialMusicianCommand, UpdatePartialMusicianResult> UpdatePartialMusicianUseCase { get; }
        public ICommandUseCase<DeleteMusicianCommand, DeleteMusicianResult> DeleteMusicianUseCase { get; }



        public MusicianApplicationService(
           ICommandUseCase<CreateMusicianCommand, CreateMusicianResult> createMusicianUseCase,
           ICommandUseCase<UpsertMusicianCommand, UpsertMusicianResult> upsertMusicianUseCase,
           ICommandUseCase<UpdatePartialMusicianCommand, UpdatePartialMusicianResult> updatePartialMusicianUseCase,
           ICommandUseCase<DeleteMusicianCommand, DeleteMusicianResult> deleteMusicianUseCase,
           IQueryUseCase<GetAllMusiciansQuery, GetAllMusiciansResult> getAllMusiciansUseCase,
           IQueryUseCase<GetMusicianByMusicianIdQuery, GetMusicianByMusicianIdResult> getMusicianByMusicianIdUseCase
       )
        {
            CreateMusicianUseCase = createMusicianUseCase;
            UpsertMusicianUseCase = upsertMusicianUseCase;
            UpdatePartialMusicianUseCase = updatePartialMusicianUseCase;
            DeleteMusicianUseCase = deleteMusicianUseCase;
            GetAllMusiciansUseCase = getAllMusiciansUseCase;
            GetMusicianByMusicianIdUseCase = getMusicianByMusicianIdUseCase;
        }


    }
}
