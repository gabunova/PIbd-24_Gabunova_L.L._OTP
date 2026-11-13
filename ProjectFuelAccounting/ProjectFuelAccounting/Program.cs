using ProjectFuelAccounting.Repositories;
using ProjectFuelAccounting.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

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
        container.RegisterType<IDriverRepository, DriverRepository>(new TransientLifetimeManager());
        container.RegisterType<ICarRepository, CarRepository>(new TransientLifetimeManager());
        container.RegisterType<IRouteRepository, RouteRepository>(new TransientLifetimeManager());
        container.RegisterType<IRefuelRepository, RefuelRepository>(new TransientLifetimeManager());
        container.RegisterType<IShiftRepository, ShiftRepository>(new TransientLifetimeManager());
        return container;
    }
}