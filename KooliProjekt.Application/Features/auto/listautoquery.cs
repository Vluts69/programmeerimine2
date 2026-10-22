using System;
using System.Collections.Generic;
using System.Text;

using KooliProjekt.Application.Data;
using MediatR;
using System.Collections.Generic;

namespace KooliProjekt.Application.Features.auto
{
    public class ListAutodQuery : IRequest<List<Auto>>
    {
    }
}