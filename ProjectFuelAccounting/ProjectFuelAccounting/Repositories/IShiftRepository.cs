using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories;

public interface IShiftRepository
{
    IEnumerable<Shift> ReadShifts(DateTime? dateFrom = null, DateTime? dateTo = null, int? driversId = null, int? carsId = null, int? routesId = null);
    void CreateShift(Shift shift);
    void DeleteShift(int id);
}