using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Commands.TodoCommands.UpdateTodo
{
    public class UpdateTodoCommandHandler : IRequestHandler<UpdateTodoCommand, Guid>
    {
        private readonly IRepository<Todo> _repository;
        private readonly IMapper _mapper;

        public UpdateTodoCommandHandler(IRepository<Todo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = await _repository.GetByIdAsync(request.Id);
            if (todo == null)
            {
                throw new Exception("Todo not found");
            }
            _mapper.Map(request, todo);
            await _repository.UpdateAsync(todo);
            return todo.Id;
        }
    }
}
