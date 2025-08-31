using AutoMapper;
using Disco.Service.Application.UseCases.Musician.Commands.CreateMusician;
using Disco.Service.Application.UseCases.Musician.Models;
using Disco.Service.Application.UseCases.Musician.Queries.GetAllMusicians;
using Disco.Service.Framework.Rest.Models.Dtos;
using Disco.Service.Framework.Rest.Models.Requests;
using Disco.Service.Framework.Rest.Models.Responses;
using Disco.Service.Infrastructure.JsonPatch;

namespace Disco.Service.Framework.Rest.Mappings
{
    public class RestProfile : Profile
    {
    }
}
