using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Shift
{
    [Key]
    public int Id { get; internal set; }

    [ForeignKey(nameof(Driver))]
    public int DriversId { get; internal set; }

    [ForeignKey(nameof(Car))]
    public int CarsId { get; internal set; }

    public ShiftType ShiftType { get; internal set; }
    public DateTime ShiftDate { get; internal set; }

    public Driver? Driver { get; internal set; }
    public Car? Car { get; internal set; }
    public List<ShiftRoute> ShiftRoutes { get; internal set; } = [];

    public Shift() { }

    public static Shift CreateOperation(int id, int driversId, int carsId, ShiftType shiftType, IEnumerable<ShiftRoute> shiftRoutes)
    {
        return new Shift
        {
            Id = id,
            DriversId = driversId,
            CarsId = carsId,
            ShiftType = shiftType,
            ShiftDate = DateTime.UtcNow,
            ShiftRoutes = shiftRoutes?.ToList() ?? []
        };
    }
}