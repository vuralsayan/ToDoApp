using MediatR;

namespace TodoApp.Application.Features.Queries.TagQueries.GetByIdTag
{
    public class GetByIdQueryRequest : IRequest<GetByIdQueryResponse>
    {
        public GetByIdQueryRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
