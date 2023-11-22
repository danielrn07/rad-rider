using RadRiderWebApp.Models;

namespace RadRiderWebApp.Services;

public interface ISkateService
{
    IList<Skate> GetAll();
    Skate GetSkate(int id);
    void InsertSkate(Skate skate);
}