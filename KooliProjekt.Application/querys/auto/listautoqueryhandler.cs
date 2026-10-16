using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;




namespace KooliProjekt.Application.Queries.Autod
{
    public class ListAutodQueryHandler
        : IRequestHandler<ListAutodQuery, List<Auto>>
    {
        private readonly ApplicationDbContext _context;

        public ListAutodQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Auto>> Handle(
            ListAutodQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Autod
                .ToListAsync(cancellationToken);
        }
    }
}
