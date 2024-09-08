using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Commands.TodoCommands.CreateTodo
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
    {
        private readonly IRepository<Todo> _repository;
        private readonly IMapper _mapper;

        public CreateTodoCommandHandler(IRepository<Todo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = _mapper.Map<Todo>(request);
            await _repository.CreateAsync(todo);
            return todo.Id;
        }
    }
}
