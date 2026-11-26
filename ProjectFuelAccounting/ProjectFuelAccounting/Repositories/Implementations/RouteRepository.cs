using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class RouteRepository : IRouteRepository
{
    private readonly DataContext _context;
    private readonly ILogger<RouteRepository> _logger;

    public RouteRepository(DataContext context, ILogger<RouteRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateRoute(Route route)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(route));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Routes.Add(route);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void UpdateRoute(Route route)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonSerializer.Serialize(route));
        try
        {
            _context.ChangeTracker.Clear();
            _context.Routes.Update(route);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteRoute(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            _context.ChangeTracker.Clear();
            var route = _context.Routes.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _context.Routes.Remove(route);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Route ReadRouteById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var route = _context.Routes.AsNoTracking().FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Объект не найден");
            _logger.LogDebug("Найденный объект: {json}", JsonSerializer.Serialize(route));
            return route;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Route> ReadRoutes()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var routes = _context.Routes.AsNoTracking().ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonSerializer.Serialize(routes));
            return routes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}