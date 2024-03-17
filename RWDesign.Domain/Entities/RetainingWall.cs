namespace RWDesign.Domain.Entities;

public class RetainingWall : BaseEntity
{
    public double Height { get; set; }
    public double Length { get; set; }
    public double Thickness { get; set; }
    public string Material { get; set; } = default!;
}
