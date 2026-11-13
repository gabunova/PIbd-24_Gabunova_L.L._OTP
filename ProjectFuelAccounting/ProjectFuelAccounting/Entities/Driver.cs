using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Driver
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string LicenseNumber { get; private set; } = string.Empty;
    public int Experience { get; private set; }
    public VehicleCategory AllowedCategory { get; private set; }

    public static Driver CreateEntity(int id, string fullName, string licenseNumber, int experience, VehicleCategory allowedCategory)
    {
        return new Driver
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            LicenseNumber = licenseNumber ?? string.Empty,
            Experience = experience,
            AllowedCategory = allowedCategory
        };
    }
}