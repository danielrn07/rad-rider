namespace RadRiderWebApp.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<Skate> Skates { get; set; }
}