namespace ControleTarefas.Application.UseCases.CreateTarefa;
public sealed record DeleteTarefaResponse
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string? Descricao { get; set; }
}
