namespace RWDesign.Domain.Entities;

public class DesignLoad : BaseEntity
{
    public double SurchargeLoad { get; set; }
    public double LiveLoad { get; set; }
    public double SeismicLoad { get; set; }
}
