using MassTransit;
using RWDesign.Domain.Shared;

namespace RWDesign.Domain.Entities;

public abstract class BaseEntity : IAuditBase, ISoftDeletable
{
    public string Id { get; set; } = NewId.Next().ToSequentialGuid().ToString();
    public bool IsDeleted { get; set; }
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
    public string? CreatedFrom { get; set; }
    public string? ModifiedFrom { get; set; }
}
