using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Features.Commands.TagCommands.CreateTag;
using TodoApp.Application.Features.Commands.TagCommands.RemoveTag;
using TodoApp.Application.Features.Commands.TagCommands.UpdateTag;
using TodoApp.Application.Features.Queries.TagQueries.GetAllTag;
using TodoApp.Application.Features.Queries.TagQueries.GetByIdTag;

namespace TodoApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllTagQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetByIdTagQueryRequest(id));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result); ;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTagCommand command)
        {
            Guid tagId = await _mediator.Send(command);
            return Ok($"{tagId} - numaralı etiket başarılı bir şekilde oluşturuldu.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Guid tagId = await _mediator.Send(new RemoveTagByIdCommand(id));
            return Ok($"{tagId} - numaralı etiket başarılı bir şekilde silindi.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTagCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            Guid tagId = await _mediator.Send(command);
            return Ok($"{tagId} - numaralı etiket başarılı bir şekilde güncellendi.");
        }
    }
}
