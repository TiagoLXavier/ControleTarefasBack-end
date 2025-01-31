using AutoMapper;
using ControleTarefas.Domain.Entities;

namespace ControleTarefas.Application.UseCases.CreateTarefa;
public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteTarefaRequest, Tarefa>();
        CreateMap<Tarefa, DeleteTarefaResponse>();
    }
}
