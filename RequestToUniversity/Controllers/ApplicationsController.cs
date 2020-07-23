using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.DataAccess;
using Domain.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Threading;
using RequestToUniversity.App.Application.GetById.Queries;
using RequestToUniversity.App.Application.GetAll.Queries;
using RequestToUniversity.App.Application.Commands.Create;
using RequestToUniversity.App.Application.Commands.Delete;
using RequestToUniversity.App.Application.Commands.Update;

namespace RequestToUniversity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        IMediator _mediator;
        public ApplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Application>>> GetApplications()
        {
            var response = await _mediator.Send(new GetAllRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> GetApplication(int id, CancellationToken ct)
        {
            var request = new GetByIdRequest(id);
            var response = await _mediator.Send(request, ct);
            return response;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplication(int id, UpdateApplicationCommand command)
        {
            var request = new UpdateApplicationRequest(id, command);
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Application>> PostApplication(CreateApplicationCommand command)
        {
            var response = await _mediator.Send(command);
            return response;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Application>> DeleteApplication(int id)
        {
            var request = new DeleteApplicationRequest(id);
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
