using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.auto
{
    public class GetAutoQuery : IRequest<OperationResult<AutoListDto>>
    {
        public int Id { get; set; }
    }
}