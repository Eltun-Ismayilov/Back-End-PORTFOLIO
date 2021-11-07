using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Applications.BlogMolus;
using Portfolio.Applications.IconMolus;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IconsController : ControllerBase
    {

        readonly IMediator mediator;
        public IconsController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("{PageIndex}/{PageSize}")]
        [SwaggerOperation(Summary= "Icons Sehfe seklinde elde etmek",
         Description = "Seyfede indeksi ve pagesize vermekle Icons elde ekmek")]

        public async Task<IActionResult> Get([FromRoute] IconsPagedQuery query)
        {
            var respons = await mediator.Send(query);
            return Ok(respons);
        }


        [HttpGet("{Id}")]
        [SwaggerOperation(Summary = "{Id} gore Icons getirmek",
         Description = "Id vermekle 1 melumatin Details baxmaq ucundur")]

        public async Task<IActionResult> Details([FromRoute] IconsSingleQuery query)
        {
            var respons = await mediator.Send(query);
            if (respons==null)
            {
                return NotFound();
            }
            return Ok(respons);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Yeni Icons yaratmaq",
         Description = "Body yeni melumat yaradilir")]
        public async Task<IActionResult> Create(IconsCreateCommand comman)
        {
            var respons = await mediator.Send(comman);
            return Ok(respons);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Icon update etmek",
         Description = "Var olan Icon update etmek")]
        public async Task<IActionResult> Edit(IconsEditCommand comman)
        {
            var respons = await mediator.Send(comman);
            return Ok(respons);
        }



        [HttpDelete]
        [SwaggerOperation(Summary = "Icon Silmek etmek",
        Description = "Var olan Icon Id gore silmek ")]
        public async Task<IActionResult> Delete(int id)
        {
            var respons = await mediator.Send(new IconsRemoveCommand(id));
            return Ok(respons);
        }




    }
}
