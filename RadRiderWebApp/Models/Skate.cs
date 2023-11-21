namespace RadRiderWebApp.Models;

public class Skate
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public double Size { get; set; }
    public string Model { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public double ProductReview { get; set; }
    public int Amount { get; set; }
    public double Price { get; set; }
    public bool LimitedEdition { get; set; }
    public DateTime ManufacturinDate { get; set; }
}