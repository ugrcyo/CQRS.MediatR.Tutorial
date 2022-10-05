using DAL.CQRS.Queries.Response;
using MediatR;

namespace DAL.CQRS.Queries.Request
{
    public class GetByIdQueryRequest:IRequest<GetByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
