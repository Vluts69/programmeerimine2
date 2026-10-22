using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.Tootajad
{
    public class GettootajaQuery : IRequest<Auto?>
    {
        public int Id { get; set; }
    }
}
