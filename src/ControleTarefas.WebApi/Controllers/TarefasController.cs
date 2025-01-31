using CleanArchitecture.Application.UseCases.GetByIdTarefa;
using CleanArchitecture.Application.UseCases.UpdateUser;
using ControleTarefas.Application.UseCases.CreateTarefa;
using ControleTarefas.Application.UseCases.GetTarefasPorStatus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ControleTarefas.WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class TarefasController : ControllerBase
{
    IMediator _mediator;
    public TarefasController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetByIdTarefaResponse>> GetById(int id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetByIdTarefaRequest(id), cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetTarefasPorStatusResponse>>> GetAll([FromQuery] GetTarefasPorStatusRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTarefaRequest request)
    {
        var tarefaId = await _mediator.Send(request);

        return Ok(tarefaId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateTarefaResponse>>
        Update(int id, UpdateTarefaRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
            return BadRequest("O ID da rota e o ID da requisição não correspondem.");

        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int? id,
                                           CancellationToken cancellationToken)
    {
        if (id is null)
            return BadRequest("O ID da tarefa é obrigatório.");

        var deleteTarefaRequest = new DeleteTarefaRequest(id.Value);

        var response = await _mediator.Send(deleteTarefaRequest, cancellationToken);
        return Ok(response);
    }
}
