namespace RWDesign.Domain.Entities;

public class Material : BaseEntity
{
    public string Name { get; set; } = default!;
    public double Density { get; set; }
    public double Strength { get; set; }
}
