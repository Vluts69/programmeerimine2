using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;


namespace KooliProjekt.Application.Features.auto
{
    public class GetAutoQuery : IRequest<Auto?>
    {
        public int Id { get; set; }
    }
}
