using Microsoft.Extensions.DependencyInjection;
using MyFinance.Application.Commands.User;

namespace MyFinance.Application.IocApplication;

public static class ApplicationModule
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        services.AddMediatR(config =>
                config.RegisterServicesFromAssemblyContaining<UserCreateCommand>());

        return services;
    }
}
