using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Features.Commands.TodoCommands.CreateTodo;
using TodoApp.Application.Features.Commands.TodoCommands.RemoveTodo;
using TodoApp.Application.Features.Commands.TodoCommands.UpdateTodo;
using TodoApp.Application.Features.Queries.TodoQueries.GetAllTodo;
using TodoApp.Application.Features.Queries.TodoQueries.GetByIdTodo;

namespace TodoApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todos = await _mediator.Send(new GetAllTodoQueryRequest());
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var todo = await _mediator.Send(new GetByIdTodoQueryRequest(id));
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTodoCommand command)
        {
            Guid todoId = await _mediator.Send(command);
            return Ok($"{todoId} - numaralı todo başarılı bir şekilde oluşturuldu.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Guid todoId = await _mediator.Send(new RemoveTodoByIdCommand(id));
            return Ok($"{todoId} - numaralı todo başarılı bir şekilde silindi.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTodoCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            Guid todoId = await _mediator.Send(command);
            return Ok($"{todoId} - numaralı todo başarılı bir şekilde güncellendi.");
        }
    }
}
