using CQRS.DAL;
using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommandRequest, DeleteCommandResponse>
    {
        public async Task<DeleteCommandResponse> Handle(DeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteDeveloper = ApplicationDbContext.DeveloperList.FirstOrDefault(p => p.Id == request.Id);
            ApplicationDbContext.DeveloperList.Remove(deleteDeveloper);
            return new DeleteCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}