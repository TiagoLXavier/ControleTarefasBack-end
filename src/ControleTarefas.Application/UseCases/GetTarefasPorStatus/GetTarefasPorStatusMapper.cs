using AutoMapper;
using ControleTarefas.Domain.Entities;

namespace ControleTarefas.Application.UseCases.GetTarefasPorStatus;

public sealed class GetTarefasPorStatusMapper : Profile
{
    public GetTarefasPorStatusMapper()
    {
        CreateMap<Tarefa, GetTarefasPorStatusResponse>();
    }
}
