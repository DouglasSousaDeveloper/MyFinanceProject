using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Infrastructure.Context;
using MyFinance.Infrastructure.Interfaces.Generic;
using MyFinance.Infrastructure.Repositories;
using MyFinance.Infrastructure.Repositories.Generic;

namespace MyFinance.Infrastructure.IocInfrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IFinancialGoalRepository, FinancialGoalRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        return services;
    }

    public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DevFreelaCs");

        services.AddDbContext<MyFinanceContext>(o => o.UseNpgsql(connectionString));


        return services;
    }
}
