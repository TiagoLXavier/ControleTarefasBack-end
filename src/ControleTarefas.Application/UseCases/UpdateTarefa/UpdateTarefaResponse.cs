namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed record UpdateTarefaResponse
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string? Descricao { get; set; }
}
