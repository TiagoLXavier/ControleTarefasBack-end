using ControleTarefas.Domain.Enums;

namespace ControleTarefas.Application.UseCases.GetTarefasPorStatus;

public sealed record GetTarefasPorStatusResponse
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string? Descricao { get; set; }
    public StatusTarefa Status { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public DateTime? DataConclusao { get; set; }
}
