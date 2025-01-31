using MediatR;

namespace CleanArchitecture.Application.UseCases.GetByIdTarefa;

public sealed record GetByIdTarefaRequest(int Id) : 
                   IRequest<GetByIdTarefaResponse>;