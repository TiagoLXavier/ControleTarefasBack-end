using AutoMapper;
using ControleTarefas.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.GetByIdTarefa;

public sealed class GetByIdTarefaMapper : Profile
{
    public GetByIdTarefaMapper()
    {
        CreateMap<Tarefa, GetByIdTarefaResponse>();
    }
}
