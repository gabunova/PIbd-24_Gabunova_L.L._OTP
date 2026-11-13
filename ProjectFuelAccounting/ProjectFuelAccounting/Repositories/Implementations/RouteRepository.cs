using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class RouteRepository : IRouteRepository
{
    public void CreateRoute(Route route)
    {
    }

    public void DeleteRoute(int id)
    {
    }

    public Route ReadRouteById(int id)
    {
        return Route.CreateEntity(0, string.Empty, 0);
    }

    public IEnumerable<Route> ReadRoutes()
    {
        return [];
    }

    public void UpdateRoute(Route route)
    {
    }
}