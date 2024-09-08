using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Queries.TagQueries.GetByIdTag
{
    public class GetByIdTagQueryHandler : IRequestHandler<GetByIdTagQueryRequest, GetByIdTagQueryResponse>
    {
        private readonly IRepository<Tag> _repository;
        private readonly IMapper _mapper;

        public GetByIdTagQueryHandler(IRepository<Tag> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetByIdTagQueryResponse> Handle(GetByIdTagQueryRequest request, CancellationToken cancellationToken)
        {
            var tag = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetByIdTagQueryResponse>(tag);
        }
    }
}
