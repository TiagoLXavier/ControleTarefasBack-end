using ControleTarefas.Domain.Entities;

namespace ControleTarefas.Domain.Interfaces;

public interface ITarefaRepository : IBaseRepository<Tarefa>
{
    Task<List<Tarefa>> GetTarefasPorStatus(int status, CancellationToken cancellationToken);
}
