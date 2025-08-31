using SharedKernel.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Application.UseCases.Interfaces
{
    public interface IUseCase<TPutUseCase, TResult>
       where TPutUseCase : IPutUseCase
       where TResult : IResult
    {
        Task<TResult> ExecuteAsync(TPutUseCase input);
    }
    public interface IUseCase<TPutUseCase>
        where TPutUseCase : IPutUseCase
    {
        Task ExecuteAsync(TPutUseCase input);
    }
}
