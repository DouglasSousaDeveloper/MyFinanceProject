﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Core.Domains;
using MyFinance.Infrastructure.Interfaces;
using MyFinance.Infrastructure.Repositories;

namespace MyFinance.Infrastructure.IocInfrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddRepositories()
            .AddData(configuration);

        return services;
    }

    private static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
    {
        //var connectionString = configuration.GetConnectionString("DevFreelaCs");

        //services.AddDbContext<DevFreelaDbContext>(o => o.UseSqlServer(connectionString));


        return services;
    }
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();

        return services;
    }
}