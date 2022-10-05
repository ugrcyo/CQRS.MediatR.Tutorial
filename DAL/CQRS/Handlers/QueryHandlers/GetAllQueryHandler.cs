using CQRS.DAL;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Response;
using MediatR;

namespace DAL.CQRS.Handlers.QueryHandlers
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, List<GetAllQueryResponse>>
    {
        public async Task<List<GetAllQueryResponse>> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.DeveloperList.Select(developer => new GetAllQueryResponse
            {
                Id = developer.Id,
                Name = developer.Name,
                Surname = developer.Surname,
                Title = developer.Title,
                CreateTime = developer.CreateTime
            }).ToList();
        }
    }
}