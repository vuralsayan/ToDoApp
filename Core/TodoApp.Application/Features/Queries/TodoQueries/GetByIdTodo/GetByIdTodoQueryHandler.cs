using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Queries.TodoQueries.GetByIdTodo
{
    public class GetByIdTodoQueryHandler : IRequestHandler<GetByIdTodoQueryRequest, GetByIdTodoQueryResponse>
    {
        private readonly IRepository<Todo> _repository;
        private readonly IMapper _mapper;

        public GetByIdTodoQueryHandler(IRepository<Todo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetByIdTodoQueryResponse> Handle(GetByIdTodoQueryRequest request, CancellationToken cancellationToken)
        {
            var todo = await _repository.GetByIdAsync(request.Id);
            if(todo == null)
            {
                throw new Exception("Todo not found");
            }
            return _mapper.Map<GetByIdTodoQueryResponse>(todo);
        }
    }
}
