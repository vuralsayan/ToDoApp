using MediatR;

namespace TodoApp.Application.Features.Queries.TodoQueries.GetByIdTodo
{
    public class GetByIdTodoQueryRequest : IRequest<GetByIdTodoQueryResponse>
    {
        public GetByIdTodoQueryRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
