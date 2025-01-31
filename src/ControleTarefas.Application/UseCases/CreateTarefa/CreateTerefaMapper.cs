using AutoMapper;
using ControleTarefas.Domain.Entities;

namespace ControleTarefas.Application.UseCases.CreateTarefa;
public sealed class CreateTerefaMapper : Profile
{
    public CreateTerefaMapper()
    {
        CreateMap<CreateTarefaRequest, Tarefa>();
        CreateMap<Tarefa, CreateTarefaResponse>();
    }
}
