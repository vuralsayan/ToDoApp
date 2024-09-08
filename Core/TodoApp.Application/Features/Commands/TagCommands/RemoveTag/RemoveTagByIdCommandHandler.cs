using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Commands.TagCommands.RemoveTag
{
    public class RemoveTagByIdCommandHandler : IRequestHandler<RemoveTagByIdCommand, Guid>
    {
        private readonly IRepository<Tag> _repository;

        public RemoveTagByIdCommandHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RemoveTagByIdCommand request, CancellationToken cancellationToken)
        {
            var tag = await _repository.GetByIdAsync(request.Id);
            if (tag == null)
            {
                throw new Exception("Tag not found.");
            }
            await _repository.RemoveAsync(tag);
            return tag.Id;
        }
    }
}
