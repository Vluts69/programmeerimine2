using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;


namespace KooliProjekt.Application.Queries.Autod
{
    public class GetAutoQuery : IRequest<Auto?>
    {
        public int Id { get; set; }
    }
}
