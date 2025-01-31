using ControleTarefas.Domain.Entities;
using ControleTarefas.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ControleTarefas.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Tarefa> Tarefa { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TarefaConfiguration());
    }
}