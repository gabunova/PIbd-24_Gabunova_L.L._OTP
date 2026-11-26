using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectFuelAccounting.Entities.Enums;

namespace ProjectFuelAccounting.Entities;

public class Driver
{
    [Key]
    public int Id { get; internal set; }

    [Required]
    [Column("FullName")]
    public string FullName { get; internal set; } = string.Empty;

    [Required]
    public string LicenseNumber { get; internal set; } = string.Empty;

    public int Experience { get; internal set; }
    public VehicleCategory AllowedCategory { get; internal set; }

    public Driver() { }

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

    public override string ToString() => FullName;
}