using MediatR;

namespace TodoApp.Application.Features.Queries.TagQueries.GetAllTag
{
    public class GetAllTagQueryRequest : IRequest<List<GetAllTagQueryResponse>>
    {
    }
}
