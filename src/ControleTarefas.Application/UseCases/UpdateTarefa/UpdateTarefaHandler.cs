using AutoMapper;
using ControleTarefas.Domain.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public class UpdateTarefaHandler : IRequestHandler<UpdateTarefaRequest, UpdateTarefaResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public UpdateTarefaHandler(IUnitOfWork unitOfWork,
                             ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }
    public async Task<UpdateTarefaResponse> Handle(UpdateTarefaRequest command,
                                                 CancellationToken cancellationToken)
    {
        var tarefa = await _tarefaRepository.Get(command.Id, cancellationToken);

        if (tarefa is null) return default;

        tarefa.AtualizarTitulo(command.Titulo);
        tarefa.AtualizarDescricao(command.Descricao);
        tarefa.AtualizarStatus(command.Status);
        tarefa.AtualizarDataConclusao(command.DataConclusao);

        _tarefaRepository.Update(tarefa);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateTarefaResponse>(tarefa);
    }
}