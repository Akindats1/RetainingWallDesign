namespace RWDesign.Domain.Entities;

public class Foundation : BaseEntity
{
    public double Depth { get; set; }
    public string Type { get; set; } = default!;
    public double BearingCapacity { get; set; }
}
