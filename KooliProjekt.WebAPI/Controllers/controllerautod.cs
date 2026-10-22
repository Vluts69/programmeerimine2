using KooliProjekt.Application.Features.auto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    public class AutodController : ApiControllerBase

    {

        public AutodController(ISender mediator)
          : base(mediator)
        {
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var result = await Mediator.Send(new GetAutoQuery { Id = id });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await Mediator.Send(new ListAutodQuery());

            return Ok(result);
        }
    }
}