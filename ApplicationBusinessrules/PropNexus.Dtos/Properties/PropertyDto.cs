namespace PropNexus.Dtos.Properties;

public class PropertyDto
{
    public long Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int SquareFeet { get; set; }
    public string PropertyType { get; set; } = string.Empty;
    public string? Description { get; set; }
    public long? OwnerId { get; set; }
}
