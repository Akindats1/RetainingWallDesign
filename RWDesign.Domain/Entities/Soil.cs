namespace RWDesign.Domain.Entities;

public class Soil : BaseEntity
{
    public double Cohesion { get; set; }
    public double FrictionAngle { get; set; }
    public double UnitWeight { get; set; }
}
