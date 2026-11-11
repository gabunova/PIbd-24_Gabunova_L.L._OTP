using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Shift
{
    public int Id { get; private set; }
    public int DriversId { get; private set; }
    public int CarsId { get; private set; }
    public ShiftType ShiftType { get; private set; }
    public DateTime ShiftDate { get; private set; }
    public IEnumerable<ShiftRoute> ShiftRoutes { get; private set; } = [];

    public static Shift CreateOperation(int id, int driversId, int carsId, ShiftType shiftType, IEnumerable<ShiftRoute> shiftRoutes)
    {
        return new Shift
        {
            Id = id,
            DriversId = driversId,
            CarsId = carsId,
            ShiftType = shiftType,
            ShiftDate = DateTime.Now,
            ShiftRoutes = shiftRoutes ?? []
        };
    }
}