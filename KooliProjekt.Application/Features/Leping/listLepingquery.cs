using System;
using System.Collections.Generic;
using System.Text;

using KooliProjekt.Application.Data;
using MediatR;


namespace KooliProjekt.Application.Features.leping
{
    public class ListLepingQuery : IRequest<List<KooliProjekt.Application.Data.Leping?>>
    {
        public int Id { get; set; }
        

    }
}