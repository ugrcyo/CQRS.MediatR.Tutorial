using DAL.CQRS.Commands.Response;
using MediatR;

namespace DAL.CQRS.Commands.Request
{
    public class UpdateCommandRequest : IRequest<UpdateCommandResponse>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
