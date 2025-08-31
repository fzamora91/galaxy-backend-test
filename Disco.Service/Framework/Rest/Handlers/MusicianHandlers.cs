using AutoMapper;
using Disco.Service.Framework.Rest.Models.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians;
using Disco.Service.Application.UseCases.Musician.Interfaces;

namespace Disco.Service.Framework.Rest.Handlers
{
    public static class MusicianHandlers
    {

        public static async Task<Results<BadRequest, Ok<GetAllMusiciansResponse>>> GetAllMusiciansAsync(
            [FromServices] IMusicianApplicationService _musicianApplicationService,
            [FromServices] IMapper _mapper
        )
        {
            var query = new GetAllMusiciansQuery();
            var result = await _musicianApplicationService.GetAllMusiciansUseCase.ExecuteAsync(query);
            var response = _mapper.Map<GetAllMusiciansResponse>(result);

            return TypedResults.Ok(response);
        }

    }
}
