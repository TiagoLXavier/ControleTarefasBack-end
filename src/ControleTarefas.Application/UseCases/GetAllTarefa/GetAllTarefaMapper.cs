using AutoMapper;
using ControleTarefas.Domain.Entities;

namespace ControleTarefas.Application.UseCases.GetAllTarefa;

public sealed class GetAllTarefaMapper : Profile
{
    public GetAllTarefaMapper()
    {
        CreateMap<Tarefa, GetAllTarefaResponse>();
    }
}
