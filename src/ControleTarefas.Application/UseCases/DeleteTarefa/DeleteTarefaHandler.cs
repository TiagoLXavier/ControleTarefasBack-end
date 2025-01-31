using AutoMapper;
using ControleTarefas.Domain.Interfaces;
using MediatR;

namespace ControleTarefas.Application.UseCases.CreateTarefa;

public sealed class DeleteTarefaHandler :
                    IRequestHandler<DeleteTarefaRequest, DeleteTarefaResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public DeleteTarefaHandler(IUnitOfWork unitOfWork,
                             ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }

    public async Task<DeleteTarefaResponse> Handle(DeleteTarefaRequest request,
                                                 CancellationToken cancellationToken)
    {
        var tarefa = await _tarefaRepository.Get(request.Id, cancellationToken);

        if (tarefa == null) return default;

        _tarefaRepository.Delete(tarefa);
        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteTarefaResponse>(tarefa);
    }
}
