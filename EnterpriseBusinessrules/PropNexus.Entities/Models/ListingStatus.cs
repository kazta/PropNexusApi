namespace PropNexus.Entities.Models;
public class ListingStatus
{
    public long Id { get; set; }
    public string StatusName { get; set; } = string.Empty;
    public string? Description { get; set; }
}