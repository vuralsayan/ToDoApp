using AutoMapper;
using MediatR;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Domain.Entities;


namespace TodoApp.Application.Features.Queries.TagQueries.GetAllTag
{
    public class GetAllTagQueryHandler : IRequestHandler<GetAllTagQueryRequest, List<GetAllTagQueryResponse>>
    {
        private readonly IRepository<Tag> _repository;
        private readonly IMapper _mapper;

        public GetAllTagQueryHandler(IRepository<Tag> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTagQueryResponse>> Handle(GetAllTagQueryRequest request, CancellationToken cancellationToken)
        {
            var tagList = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAllTagQueryResponse>>(tagList);
        }
    }
}
