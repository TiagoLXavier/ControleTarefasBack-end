using MediatR;

namespace ControleTarefas.Application.UseCases.GetAllTarefa;

public sealed record GetAllTarefaRequest: 
                   IRequest<List<GetAllTarefaResponse>>;
