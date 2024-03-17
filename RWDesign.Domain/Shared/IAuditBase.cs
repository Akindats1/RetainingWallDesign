namespace RWDesign.Domain.Shared;

public interface IAuditBase
{
    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? CreatedFrom { get; set; }

    public string? ModifiedFrom { get; set; }
}
