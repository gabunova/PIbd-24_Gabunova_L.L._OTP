using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class ShiftRepository : IShiftRepository
{
    public void CreateShift(Shift shift)
    {
    }

    public void DeleteShift(int id)
    {
    }

    public IEnumerable<Shift> ReadShifts(DateTime? dateFrom = null, DateTime? dateTo = null, int? driversId = null, int? carsId = null, int? routesId = null)
    {
        return [];
    }
}