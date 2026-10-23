using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.auto
{
    public class GetAutoQueryHandler
        : IRequestHandler<GetAutoQuery, OperationResult<AutoListDto>>
    {
        private readonly ApplicationDbContext _context;

        public GetAutoQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OperationResult<AutoListDto>> Handle(
            GetAutoQuery request,
            CancellationToken cancellationToken)
        {
            var result = new OperationResult<AutoListDto>();

            result.Value = await _context.Autod
                .AsNoTracking()
                .Where(auto => auto.Id == request.Id)
                .Select(auto => new AutoListDto
                {
                    Id = auto.Id,
                    Mark = auto.Mark,
                    Mudel = auto.Mudel,
                    Registreerimisnumber = auto.Registreerimisnumber,
                    VIN = auto.VIN
                })
                .FirstOrDefaultAsync(cancellationToken);

            return result;
        }
    }
}
