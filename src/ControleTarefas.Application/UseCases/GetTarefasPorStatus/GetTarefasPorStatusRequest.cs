using ControleTarefas.Domain.Enums;
using MediatR;

namespace ControleTarefas.Application.UseCases.GetTarefasPorStatus;

public sealed record GetTarefasPorStatusRequest(StatusTarefa Status): 
                   IRequest<List<GetTarefasPorStatusResponse>>;
