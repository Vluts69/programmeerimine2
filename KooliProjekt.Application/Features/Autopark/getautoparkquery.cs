using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.Autopark
{
    public class GetAutoparkQuery : IRequest<Auto?>
    {
        public int Id { get; set; }
    }
}
