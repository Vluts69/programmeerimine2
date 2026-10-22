using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.Leping
{
    public class GetlepingQuery : IRequest<Leping?>
    {
        public int Id { get; set; }
    }
}
