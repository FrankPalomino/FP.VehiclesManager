namespace FP.VehiclesManager.Infrastructure.Contracts.Entities;

public partial class Vehicle
{
    public int Id { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? Power { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
