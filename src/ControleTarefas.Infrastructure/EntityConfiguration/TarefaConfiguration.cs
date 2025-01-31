using ControleTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleTarefas.Infrastructure.EntityConfiguration;

public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
{
    public void Configure(EntityTypeBuilder<Tarefa> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Titulo).HasMaxLength(100).IsRequired();
        builder.Property(m => m.Descricao).HasMaxLength(100);
        builder.Property(m => m.Status).IsRequired();

        /*builder.HasData(
            new Tarefa(),
            new Tarefa()
        );*/
    }
}
