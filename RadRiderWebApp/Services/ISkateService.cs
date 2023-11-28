using RadRiderWebApp.Models;

namespace RadRiderWebApp.Services;

public interface ISkateService
{
    IList<Skate> GetAll();
    IList<Brand> GetAllBrands();
    IList<SkateModel> GetAllModels();
    Skate GetSkate(int id);
    void InsertSkate(Skate skate);
    void EditSkate(Skate skate);
    void DeleteSkate(int id);
}