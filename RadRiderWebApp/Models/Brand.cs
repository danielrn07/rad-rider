namespace RadRiderWebApp.Models;

public class Brand
{
    public int BrandId { get; set; }
    public string Name { get; set; }
    public ICollection<Skate>? Skates { get; set; }
}