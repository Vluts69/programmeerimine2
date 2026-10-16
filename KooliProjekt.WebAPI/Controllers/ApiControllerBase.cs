using KooliProjekt.Application.Infrastructure.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using MediatR;
namespace KooliProjekt.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        protected ISender Mediator { get; }

        protected ApiControllerBase(ISender mediator)
        {
            Mediator = mediator;
        }
    }
}