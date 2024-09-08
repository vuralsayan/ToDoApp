using MediatR;

namespace TodoApp.Application.Features.Queries.TodoQueries.GetAllTodo
{
    public class GetAllTodoQueryRequest : IRequest<List<GetAllTodoQueryResponse>>
    {
    }
}
