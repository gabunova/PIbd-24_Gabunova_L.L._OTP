using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class RefuelRepository : IRefuelRepository
{
    public void CreateRefuel(Refuel refuel)
    {
    }

    public IEnumerable<Refuel> ReadRefuels(DateTime? dateFrom = null, DateTime? dateTo = null, int? carsId = null, int? driversId = null)
    {
        return [];
    }
}