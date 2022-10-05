using CQRS.DAL;
using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using MediatR;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCommandRequest, UpdateCommandResponse>
    {
        public async Task<UpdateCommandResponse> Handle(UpdateCommandRequest request, CancellationToken cancellationToken)
        {
            var updateDeveloper = ApplicationDbContext.DeveloperList.FirstOrDefault(p => p.Id == request.Id);

            if (updateDeveloper != null)
            {
                updateDeveloper.Title = request.Title;
                updateDeveloper.CreateTime = DateTime.Now;

                return new UpdateCommandResponse
                {
                    IsSuccess = true
                };

            }
            else
            {
                throw new Exception("Developer Not Found");
            }
        }


    }
}
