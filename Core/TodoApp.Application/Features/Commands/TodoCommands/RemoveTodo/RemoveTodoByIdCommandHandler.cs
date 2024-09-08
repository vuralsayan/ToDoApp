using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Commands.TodoCommands.RemoveTodo
{
    public class RemoveTodoByIdCommandHandler : IRequestHandler<RemoveTodoByIdCommand, Guid>
    {
        private readonly IRepository<Todo> _repository;

        public RemoveTodoByIdCommandHandler(IRepository<Todo> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RemoveTodoByIdCommand request, CancellationToken cancellationToken)
        {
            var todo = await _repository.GetByIdAsync(request.Id);
            if (todo == null)
            {
                throw new Exception("Todo not found");
            }
            await _repository.RemoveAsync(todo);
            return todo.Id;
        }
    }
}
