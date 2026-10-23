using KooliProjekt.Application.Features.leping;
using KooliProjekt.Application.Features.Leping;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    public class LepingudController : ApiControllerBase

    {

        public LepingudController(ISender mediator)
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

            var result = await Mediator.Send(new GetLepingQuery { Id = id });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await Mediator.Send(new ListLepingQuery());

            return Ok(result);
        }
    }
}