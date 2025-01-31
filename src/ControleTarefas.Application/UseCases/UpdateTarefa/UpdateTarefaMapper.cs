using AutoMapper;
using ControleTarefas.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed class UpdateTarefaMapper : Profile
{
    public UpdateTarefaMapper()
    {
        CreateMap<UpdateTarefaRequest, Tarefa>();
        CreateMap<Tarefa, UpdateTarefaResponse>();
    }
}
