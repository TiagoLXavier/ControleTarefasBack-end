using ControleTarefas.Domain.Enums;

namespace CleanArchitecture.Application.UseCases.GetByIdTarefa;

public sealed record GetByIdTarefaResponse
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string? Descricao { get; set; }
    public StatusTarefa Status { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public DateTime? DataConclusao { get; set; }
}
