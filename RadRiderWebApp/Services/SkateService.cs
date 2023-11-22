using RadRiderWebApp.Models;

namespace RadRiderWebApp.Services;

public class SkateService : ISkateService
{
    public SkateService()
        => LoadInitialList();
    
    private IList<Skate> _skates;

    private void LoadInitialList()
    {
        _skates = new List<Skate>()
        {
            new Skate
            {
                Id = 1,
                Name = "Cool Cruiser",
                Description = "A versatile skateboard for cruising and tricks.",
                ImagePath = "/img/skate1.jpg",
                Size = 8.0,
                Model = "Cruiser X",
                Category = "Street",
                Brand = "Radical Rides",
                ProductReview = 4.5,
                Amount = 50,
                Price = 89.99,
                LimitedEdition = false,
                ManufacturingDate = new DateTime(2023, 5, 12)
            },
            new Skate
            {
                Id = 2,
                Name = "Freestyle Master",
                Description = "Specially designed for freestyle skateboarding.",
                ImagePath = "/img/skate1.jpg",
                Size = 7.75,
                Model = "Freak Flex",
                Category = "Freestyle",
                Brand = "SkatePro",
                ProductReview = 4.8,
                Amount = 30,
                Price = 109.95,
                LimitedEdition = true,
                ManufacturingDate = new DateTime(2023, 8, 28)
            },
            new Skate
            {
                Id = 3,
                Name = "Speed Demon",
                Description = "Built for speed and control, perfect for downhill riding.",
                ImagePath = "/img/skate1.jpg",
                Size = 9.0,
                Model = "Velocity V2",
                Category = "Downhill",
                Brand = "SwiftSkates",
                ProductReview = 4.9,
                Amount = 15,
                Price = 149.99,
                LimitedEdition = false,
                ManufacturingDate = new DateTime(2023, 2, 5)
            },
            new Skate
            {
                Id = 4,
                Name = "Artistic Cruiser",
                Description = "Aesthetic cruiser board with artistic designs.",
                ImagePath = "/img/skate1.jpg",
                Size = 8.25,
                Model = "Artisan A1",
                Category = "Artistic",
                Brand = "Graffiti Boards",
                ProductReview = 4.7,
                Amount = 20,
                Price = 99.50,
                LimitedEdition = true,
                ManufacturingDate = new DateTime(2023, 10, 15)
            }
        };
    }
    
    public IList<Skate> GetAll()
        => _skates;
    
    public Skate GetSkate(int id)
        => GetAll().SingleOrDefault(skate => skate.Id == id);

    public void InsertSkate(Skate skate)
    {
        var nextId = _skates.Max(item => item.Id) + 1;
        skate.Id = nextId;
        _skates.Add(skate);
    }

    public void EditSkate(Skate skate)
    {
        var skateFound = _skates.SingleOrDefault(item => item.Id == skate.Id);
        skateFound.Name = skate.Name;
        skateFound.Description = skate.Description;
        skateFound.ImagePath = skate.ImagePath;
        skateFound.Size = skate.Size;
        skateFound.Model = skate.Model;
        skateFound.Category = skate.Category;
        skateFound.Brand = skate.Brand;
        skateFound.Amount = skate.Amount;
        skateFound.Price = skate.Price;
        skateFound.LimitedEdition = skate.LimitedEdition;
        skateFound.ManufacturingDate = skate.ManufacturingDate;
    }
}