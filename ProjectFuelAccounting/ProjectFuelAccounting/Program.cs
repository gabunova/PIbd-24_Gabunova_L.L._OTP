using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProjectFuelAccounting.Repositories;
using ProjectFuelAccounting.Repositories.Implementations;
using Serilog;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.Logging;

namespace ProjectFuelAccounting;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<FormFuelAccounting>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();
        container.AddExtension(new LoggingExtension(CreateLoggerFactory()));
        container.RegisterType<DataContext>(new TransientLifetimeManager());
        container.RegisterType<IDriverRepository, DriverRepository>(new TransientLifetimeManager());
        container.RegisterType<ICarRepository, CarRepository>(new TransientLifetimeManager());
        container.RegisterType<IRouteRepository, RouteRepository>(new TransientLifetimeManager());
        container.RegisterType<IRefuelRepository, RefuelRepository>(new TransientLifetimeManager());
        container.RegisterType<IShiftRepository, ShiftRepository>(new TransientLifetimeManager());
        return container;
    }

    private static LoggerFactory CreateLoggerFactory()
    {
        var loggerFactory = new LoggerFactory();
        loggerFactory.AddSerilog(new LoggerConfiguration()
            .ReadFrom.Configuration(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build())
            .CreateLogger());
        return loggerFactory;
    }
}