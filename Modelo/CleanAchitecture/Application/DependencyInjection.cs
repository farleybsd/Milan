using Application.Abstractions.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register custom IQueryHandler and ICommandHandler

        services.Scan(scan => scan
             .FromAssembliesOf(typeof(DependencyInjection))
             .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<>)), publicOnly: false)
                 .AsImplementedInterfaces()
             .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<,>)), publicOnly: false)
                 .AsImplementedInterfaces()
             .WithScopedLifetime());
        return services;
    }
}
