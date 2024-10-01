namespace PropNexus.Entities.Models;
public class PropertyImage
{
    public long Id { get; set; }
    public long PropertyId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string? Description { get; set; }
}