using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
namespace KooliProjekt.Application.Features.leping
{
    public class GetLepingQueryHandler
        : IRequestHandler<
            GetLepingQuery,
            KooliProjekt.Application.Data.Leping?>
    {
        private readonly ApplicationDbContext _context;

        public GetLepingQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<KooliProjekt.Application.Data.Leping?> Handle(
            GetLepingQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Lepingud
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);
        }
    }
}