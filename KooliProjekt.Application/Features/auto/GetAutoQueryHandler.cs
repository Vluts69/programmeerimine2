using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;






namespace KooliProjekt.Application.Features.auto
{
    public class GetAutoQueryHandler
        : IRequestHandler<GetAutoQuery, Auto?>
    {
        private readonly ApplicationDbContext _context;

        public GetAutoQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Auto?> Handle(
            GetAutoQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Autod
                .FirstOrDefaultAsync(
                    auto => auto.Id == request.Id,
                    cancellationToken);
        }
    }
}