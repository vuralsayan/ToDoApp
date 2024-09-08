#nullable disable
using MediatR;

namespace TodoApp.Application.Features.Commands.TodoCommands.CreateTodo
{
    public class CreateTodoCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public Guid TagId { get; set; }
    }
}
