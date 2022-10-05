using CQRS.DAL;
using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class CreateCommandHandler : IRequestHandler<CreateCommandRequest, CreateCommandResponse>
    {
        public async Task<CreateCommandResponse> Handle(CreateCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.DeveloperList.Add(new()
            {
                Id = id,
                Name = request.Name,
                Surname = request.Surname,
                Title = request.Title,
                CreateTime = DateTime.Now
            });
            return new CreateCommandResponse
            {
                IsSuccess = true,
                Id = id
            };
        }
    }
}
