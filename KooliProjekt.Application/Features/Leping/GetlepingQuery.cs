using KooliProjekt.Application.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;


namespace KooliProjekt.Application.Features.leping
{
    public class GetLepingQuery
        : IRequest<KooliProjekt.Application.Data.Leping?>
    {
        public int Id { get; set; }
    }
}