namespace PropNexus.Dtos.Properties;
public class PropertyTraceDto
{
    public long Id { get; set; }
    public long PropertyId { get; set; }
    public long AgentId { get; set; }
    public long ClientId { get; set; }
    public DateTime ListingDate { get; set; }
    public long StatusId { get; set; }
}