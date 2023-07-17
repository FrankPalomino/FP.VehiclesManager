namespace FP.VehiclesManager.Infrastructure.Contracts.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Dni { get; set; }

    public string? Card { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
