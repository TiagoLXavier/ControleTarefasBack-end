using MediatR;

namespace ControleTarefas.Application.UseCases.CreateTarefa
{
   public sealed record DeleteTarefaRequest(int Id) :
         IRequest<DeleteTarefaResponse>;
}
