using RadRiderWebApp.Models;

namespace RadRiderWebApp.Services;

public interface ISkateService
{
    IList<Skate> GetAll();
    IList<Brand> GetAllBrands();
    Brand GetBrand(int id);
    IList<SkateModel> GetAllModels();
    SkateModel GetSkateModel(int id);
    IList<Category> GetAllCategories();
    IList<Tag> GetAllTags();
    Category GetCategory(int id);
    Skate GetSkate(int id);
    void InsertSkate(Skate skate);
    void EditSkate(Skate skate);
    void DeleteSkate(int id);
}