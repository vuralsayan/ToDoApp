using MediatR;

namespace TodoApp.Application.Features.Queries.TagQueries.GetByIdTag
{
    public class GetByIdTagQueryRequest : IRequest<GetByIdTagQueryResponse>
    {
        public GetByIdTagQueryRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
