using AutoMapper;
using ControleTarefas.Domain.Interfaces;
using MediatR;

namespace ControleTarefas.Application.UseCases.GetTarefasPorStatus;

public sealed class GetTarefasPorStatusHandler : IRequestHandler<GetTarefasPorStatusRequest, List<GetTarefasPorStatusResponse>>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public GetTarefasPorStatusHandler(ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }

    public async Task<List<GetTarefasPorStatusResponse>> Handle(GetTarefasPorStatusRequest request, CancellationToken cancellationToken)
    {
        var tarefas = await _tarefaRepository.GetTarefasPorStatus((Int32)request.Status,cancellationToken);
        return _mapper.Map<List<GetTarefasPorStatusResponse>>(tarefas);
    }
}
