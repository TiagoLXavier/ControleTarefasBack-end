using ControleTarefas.Domain.Entities;
using ControleTarefas.Domain.Enums;
using ControleTarefas.Domain.Interfaces;
using ControleTarefas.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleTarefas.Infrastructure.Repositories;
public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
{
    public TarefaRepository(AppDbContext context) : base(context)
    { }

    public async Task<List<Tarefa>> GetTarefasPorStatus(int status, CancellationToken cancellationToken)
    {
        if (Enum.IsDefined(typeof(StatusTarefa), status))
        {
            StatusTarefa statusEnum = (StatusTarefa)status;

            return await Context.Set<Tarefa>()
                .Where(entity => entity.Status == statusEnum)
                .ToListAsync(cancellationToken);
        }
        else
        {
            return await Context.Set<Tarefa>().ToListAsync(cancellationToken);
        }
    }
}
