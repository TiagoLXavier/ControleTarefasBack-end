using AutoMapper;
using ControleTarefas.Domain.Entities;
using ControleTarefas.Domain.Interfaces;
using MediatR;

namespace ControleTarefas.Application.UseCases.CreateTarefa;

public class CreateTarefaHandler :
       IRequestHandler<CreateTarefaRequest, CreateTarefaResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public CreateTarefaHandler(IUnitOfWork unitOfWork,
        ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }

    public async Task<CreateTarefaResponse> Handle(CreateTarefaRequest request,
        CancellationToken cancellationToken)
    {
        var tarefa = _mapper.Map<Tarefa>(request);

        tarefa.AtualizarStatus(Domain.Enums.StatusTarefa.Pendente);
        tarefa.AtualizarDataCriacao(DateTime.UtcNow);

        _tarefaRepository.Create(tarefa);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateTarefaResponse>(tarefa);
    }
}
