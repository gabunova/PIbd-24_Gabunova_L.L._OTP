using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories;

public interface IRefuelRepository
{
    IEnumerable<Refuel> ReadRefuels(DateTime? dateFrom = null, DateTime? dateTo = null, int? carsId = null, int? driversId = null);
    void CreateRefuel(Refuel refuel);
}