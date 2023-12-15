using System.ComponentModel.DataAnnotations;

namespace RadRiderWebApp.Models;

public class SkateModel
{
    [Key]
    public int SkateModelId { get; set; }
    public string Name { get; set; }
    public ICollection<Skate>? Skates { get; set; }
}