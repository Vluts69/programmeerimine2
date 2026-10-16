using System;
using System.Collections.Generic;
using System.Text;

using KooliProjekt.Application.Data;
using MediatR;
using System.Collections.Generic;

namespace KooliProjekt.Application.Queries.Autod
{
    public class ListAutodQuery : IRequest<List<Auto>>
    {
    }
}