
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.auto
{
    internal class ListAutodQueryHandler
        : IRequestHandler<
            ListAutodQuery,
            OperationResult<PagedResult<AutoListDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListAutodQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<AutoListDto>>> Handle(
            ListAutodQuery request,
            CancellationToken cancellationToken)
        {
            var result =
                new OperationResult<PagedResult<AutoListDto>>();

            result.Value = await _dbContext.Autod
                .AsNoTracking()
                .OrderByDescending(auto => auto.Id)
                .Select(auto => new AutoListDto
                {
                    Id = auto.Id,
                    Mark = auto.Mark,
                    Mudel = auto.Mudel,
                    Registreerimisnumber = auto.Registreerimisnumber
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}