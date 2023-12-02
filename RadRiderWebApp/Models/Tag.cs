namespace RadRiderWebApp.Models;

public class Tag
{
    public int TagId { get; set; }
    public string Name { get; set; }
    public ICollection<Skate>? Skates { get; set; }
}