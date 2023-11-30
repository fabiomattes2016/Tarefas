using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.Tarefa.Command.Create;
using Tarefas.Application.Tarefa.Command.Delete;
using Tarefas.Application.Tarefa.Command.Update;
using Tarefas.Application.Tarefa.Common;
using Tarefas.Application.Tarefa.Queries.GetAll;
using Tarefas.Application.Tarefa.Queries.GetById;
using Tarefas.Presentation.Contracts.Tarefa;

namespace Tarefas.Presentation.Api.Controllers
{
    [Route("[controller]")]
    public class TarefaController : ApiController
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public TarefaController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTarefa(CreateTarefaRequest request)
        {
            var command = _mapper.Map<CreateCommand>(request);
            var result = await _mediator.Send(command);

            return result.Match(
                // tarefa => CreatedAtAction(nameof(GetTarefaById), new { tarefaId = tarefa.Id }, tarefa),
                tarefa => Ok(_mapper.Map<TarefaResponse>(tarefa)),
                errors => Problem(errors)
            );
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTarefas()
        {
            var query = new GetAllQuery();
            List<TarefaResult>? result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTarefaById(string id)
        {
            var query = new GetByIdQuery(Guid.Parse(id));
            ErrorOr<TarefaResult> result = await _mediator.Send(query);

            return result.Match(
                result => Ok(_mapper.Map<TarefaResponse>(result)),
                errors => Problem(errors)
            );
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTarefa(UpdateTarefaRequest request)
        {
            var command = _mapper.Map<UpdateCommand>(request);

            ErrorOr<TarefaResult> result = await _mediator.Send(command);

            return result.Match(
                result => Ok(_mapper.Map<TarefaResponse>(result)),
                errors => Problem(errors)
            );
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTarefa(string id)
        {
            var command = new DeleteCommand(Guid.Parse(id));

            await _mediator.Send(command);

            return NoContent();
        }
    }
}