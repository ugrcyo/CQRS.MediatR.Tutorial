using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using DAL.CQRS.Handlers.CommandHandlers;
using DAL.CQRS.Handlers.QueryHandlers;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using DAL.CQRS.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Tutorial_MediatR_.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        IMediator _mediator;

        public DevelopersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get([FromQuery] GetAllQueryRequest requestModel)
        {
            List<GetAllQueryResponse> response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdQueryRequest requestModel)
        {
            GetByIdQueryResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCommandRequest requestModel)
        {
            CreateCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete([FromQuery] DeleteCommandRequest requestModel)
        {
            DeleteCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateCommandRequest requestModel)
        {
            UpdateCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

    }
}
