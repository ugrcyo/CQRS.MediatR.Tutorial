using DAL.CQRS.Commands.Response;
using MediatR;

namespace DAL.CQRS.Commands.Request
{
    public class CreateCommandRequest : IRequest<CreateCommandResponse>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
    }
}
