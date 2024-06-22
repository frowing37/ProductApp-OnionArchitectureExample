namespace ProoductApp.Domain.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    
    public DateTime CreateTime { get; set; }
}