using MediatR;

namespace TodoApp.Application.Features.Commands.TodoCommands.RemoveTodo
{
    public class RemoveTodoByIdCommand : IRequest<Guid>
    {
        public RemoveTodoByIdCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
