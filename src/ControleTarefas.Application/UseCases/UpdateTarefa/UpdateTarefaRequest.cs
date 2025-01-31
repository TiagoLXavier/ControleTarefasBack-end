using ControleTarefas.Domain.Enums;
using MediatR;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed record UpdateTarefaRequest(int Id,
                      string Titulo, string Descricao, StatusTarefa Status, DateTime DataCriacao, DateTime? DataConclusao)
                      : IRequest<UpdateTarefaResponse>;
