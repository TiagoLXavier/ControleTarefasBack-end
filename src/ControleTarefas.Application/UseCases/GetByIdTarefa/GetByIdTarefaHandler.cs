using AutoMapper;
using ControleTarefas.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.GetByIdTarefa;

public sealed class GetByIdTarefaHandler : IRequestHandler<GetByIdTarefaRequest, GetByIdTarefaResponse>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public GetByIdTarefaHandler(ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdTarefaResponse> Handle(GetByIdTarefaRequest request, CancellationToken cancellationToken)
    {
        var tarefa = await _tarefaRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetByIdTarefaResponse>(tarefa);
    }
}
