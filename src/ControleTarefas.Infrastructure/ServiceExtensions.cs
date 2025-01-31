using ControleTarefas.Domain.Interfaces;
using ControleTarefas.Infrastructure.Context;
using ControleTarefas.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControleTarefas.Infrastructure;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services,
                                                IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

        //var connectionString = configuration.GetConnectionString("Sqlite");
        //services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ITarefaRepository, TarefaRepository>();
    }
}
