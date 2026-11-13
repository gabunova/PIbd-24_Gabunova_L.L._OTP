using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories;

public interface IDriverRepository
{
    IEnumerable<Driver> ReadDrivers();
    Driver ReadDriverById(int id);
    void CreateDriver(Driver driver);
    void UpdateDriver(Driver driver);
    void DeleteDriver(int id);
}