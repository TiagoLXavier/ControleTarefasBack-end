namespace ControleTarefas.Application.UseCases.CreateTarefa;
public sealed record CreateTarefaResponse
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string? Descricao { get; set; }
}
