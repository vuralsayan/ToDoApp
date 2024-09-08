using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Commands.TagCommands.UpdateTag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, Guid>
    {
        private readonly IRepository<Tag> _repository;
        private readonly IMapper _mapper;

        public UpdateTagCommandHandler(IRepository<Tag> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = await _repository.GetByIdAsync(request.Id);
            if (tag == null)
            {
                throw new Exception("Tag not found");
            }

            _mapper.Map(request, tag);
            await _repository.UpdateAsync(tag);
            return tag.Id;
        }
    }
}
