using MediatR;

namespace TodoApp.Application.Features.Commands.TagCommands.RemoveTag
{
    public class RemoveTagByIdCommand : IRequest<Guid>
    {
        public RemoveTagByIdCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
