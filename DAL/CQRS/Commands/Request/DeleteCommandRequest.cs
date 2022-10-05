using DAL.CQRS.Commands.Response;
using MediatR;

namespace DAL.CQRS.Commands.Request
{
    public class DeleteCommandRequest : IRequest<DeleteCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
