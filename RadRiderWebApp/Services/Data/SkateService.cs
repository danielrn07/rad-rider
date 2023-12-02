using Microsoft.EntityFrameworkCore;
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

    public Brand GetBrand(int id)
        => _context.Brand.SingleOrDefault(brand => brand.BrandId == id);


    public IList<SkateModel> GetAllModels()
        => _context.SkateModel.ToList();

    public SkateModel GetSkateModel(int id)
        => _context.SkateModel.SingleOrDefault(skateModel => skateModel.SkateModelId == id);

    public IList<Category> GetAllCategories()
        => _context.Category.ToList();

    public IList<Tag> GetAllTags()
        => _context.Tag.ToList();

    public Category GetCategory(int id)
        => _context.Category.SingleOrDefault(category => category.CategoryId == id);

    public Skate GetSkate(int id)
    {
        return _context.Skate
            .Include(skate => skate.Tags)
            .SingleOrDefault(skate => skate.Id == id);
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
        skateFound.ManufacturingDate = skate.ManufacturingDate;
        skateFound.Tags = skate.Tags;
        _context.SaveChanges();
    }

    public void DeleteSkate(int id)
    {
        var skateFound = GetSkate(id);
        _context.Skate.Remove(skateFound);
        _context.SaveChanges();
    }
}