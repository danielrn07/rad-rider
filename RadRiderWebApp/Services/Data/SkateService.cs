using RadRiderWebApp.Data;
using RadRiderWebApp.Models;

namespace RadRiderWebApp.Services.Data;

public class SkateService : ISkateService
{
    private SkateDbContext _context;

    public SkateService(SkateDbContext context)
    {
        _context = context;
    }
    
    public IList<Skate> GetAll()
    {
        return _context.Skate.ToList();
    }

    public IList<Brand> GetAllBrands()
        => _context.Brand.ToList();
    
    
    public IList<SkateModel> GetAllModels()
        => _context.SkateModel.ToList();

    public IList<Category> GetAllCategories()
        => _context.Category.ToList();

    public Skate GetSkate(int id)
    {
        return _context.Skate.SingleOrDefault(skate => skate.Id == id);
    }

    public void InsertSkate(Skate skate)
    {
        _context.Skate.Add(skate);
        _context.SaveChanges();
    }

    public void EditSkate(Skate skate)
    {
        var skateFound = GetSkate(skate.Id);
        skateFound.Name = skate.Name;
        skateFound.Description = skate.Description;
        skateFound.ImagePath = skate.ImagePath;
        skateFound.Size = skate.Size;
        skateFound.SkateModelId = skate.SkateModelId;
        skateFound.CategoryId = skate.CategoryId;
        skateFound.BrandId = skate.BrandId;
        skateFound.Amount = skate.Amount;
        skateFound.Price = skate.Price;
        skateFound.LimitedEdition = skate.LimitedEdition;
        skateFound.ManufacturingDate = skate.ManufacturingDate;
        _context.SaveChanges();
    }

    public void DeleteSkate(int id)
    {
        var skateFound = GetSkate(id);
        _context.Skate.Remove(skateFound);
        _context.SaveChanges();
    }
}