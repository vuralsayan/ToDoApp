#nullable disable
using MediatR;
using TodoApp;

namespace TodoApp.Application.Features.Commands.TagCommands.CreateTag
{
    public class CreateTagCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
