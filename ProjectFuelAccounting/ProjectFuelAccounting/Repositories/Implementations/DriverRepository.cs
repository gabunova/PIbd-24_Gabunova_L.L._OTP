using ProjectFuelAccounting.Entities;
using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Repositories.Implementations;

internal class DriverRepository : IDriverRepository
{
    public void CreateDriver(Driver driver)
    {
    }

    public void DeleteDriver(int id)
    {
    }

    public Driver ReadDriverById(int id)
    {
        return Driver.CreateEntity(0, string.Empty, string.Empty, 0, VehicleCategory.None);
    }

    public IEnumerable<Driver> ReadDrivers()
    {
        return [];
    }

    public void UpdateDriver(Driver driver)
    {
    }
}