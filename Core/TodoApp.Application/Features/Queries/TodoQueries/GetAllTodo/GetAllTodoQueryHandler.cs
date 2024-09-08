using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Queries.TodoQueries.GetAllTodo
{
    public class GetAllTodoQueryHandler : IRequestHandler<GetAllTodoQueryRequest, List<GetAllTodoQueryResponse>>
    {
        private readonly IRepository<Todo> _repository;
        private readonly IMapper _mapper;

        public GetAllTodoQueryHandler(IRepository<Todo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTodoQueryResponse>> Handle(GetAllTodoQueryRequest request, CancellationToken cancellationToken)
        {
            var todos = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAllTodoQueryResponse>>(todos);
        }
    }
}
