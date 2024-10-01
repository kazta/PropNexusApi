namespace PropNexus.Dtos.ListingStatus;
public class ListingStatusDto
{
    public long Id { get; set; }
    public string StatusName { get; set; } = string.Empty;
    public string? Description { get; set; }
}