using CQRS.DAL;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using MediatR;

namespace DAL.CQRS.Handlers.QueryHandlers
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
    {
        public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var developer = ApplicationDbContext.DeveloperList.FirstOrDefault(p => p.Id == request.Id);
            if (developer == null)
            {
                return new GetByIdQueryResponse ();
            }
            else
            {
                return new GetByIdQueryResponse
                {
                    Id = developer.Id,
                    Name = developer.Name,
                    Surname = developer.Surname,
                    Title = developer.Title,
                    CreateTime = developer.CreateTime
                };
            }
            
        }
    }
}
