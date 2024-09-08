#nullable disable
using MediatR;
using TodoApp;

namespace TodoApp.Application.Features.Commands.TagCommands.UpdateTag
{
    public class UpdateTagCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
