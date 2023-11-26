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
            },
            new Skate
            {
                Id = 5,
                Name = "Retro Cruiser",
                Description = "Bringing back the old-school vibe with a modern twist.",
                ImagePath = "/img/skate1.jpg",
                Size = 8.5,
                Model = "Vintage Vibe",
                Category = "Cruiser",
                Brand = "Nostalgia Skates",
                ProductReview = 4.6,
                Amount = 25,
                Price = 79.99,
                LimitedEdition = false,
                ManufacturingDate = new DateTime(2023, 6, 20)
            },
            new Skate
            {
                Id = 6,
                Name = "Tech Thrasher",
                Description = "Advanced skateboard for technical tricks and maneuvers.",
                ImagePath = "/img/skate1.jpg",
                Size = 7.8,
                Model = "TechTrix 9000",
                Category = "Technical",
                Brand = "Innovate Boards",
                ProductReview = 4.8,
                Amount = 35,
                Price = 119.95,
                LimitedEdition = false,
                ManufacturingDate = new DateTime(2023, 4, 10)
            },
            new Skate
            {
                Id = 7,
                Name = "All-Terrain Beast",
                Description = "Designed to conquer any terrain with ease and stability.",
                ImagePath = "/img/skate1.jpg",
                Size = 8.75,
                Model = "TerrainTamer Pro",
                Category = "All-Terrain",
                Brand = "XtremeRide",
                ProductReview = 4.9,
                Amount = 18,
                Price = 159.99,
                LimitedEdition = true,
                ManufacturingDate = new DateTime(2023, 9, 8)
            },
            new Skate
            {
                Id = 8,
                Name = "Mini Ramp Ripper",
                Description = "Perfect for shredding mini ramps and skatepark bowls.",
                ImagePath = "/img/skate1.jpg",
                Size = 8.125,
                Model = "RampRage Mini",
                Category = "Ramp",
                Brand = "Airborne Skates",
                ProductReview = 4.7,
                Amount = 22,
                Price = 94.50,
                LimitedEdition = false,
                ManufacturingDate = new DateTime(2023, 7, 25)
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

    public void DeleteSkate(int id)
    {
        var skateFound = GetSkate(id);
        _skates.Remove(skateFound);
    }
}