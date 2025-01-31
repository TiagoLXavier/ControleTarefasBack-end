using ControleTarefas.Domain.Enums;
using MediatR;

namespace ControleTarefas.Application.UseCases.CreateTarefa
{
   public sealed record CreateTarefaRequest(
        string Titulo, string Descricao) :
         IRequest<CreateTarefaResponse>;
}
