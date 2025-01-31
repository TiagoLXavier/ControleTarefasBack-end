namespace ControleTarefas.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public DateTime? DataConclusao { get; set; }
}
