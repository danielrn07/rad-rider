using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class SkateDetailsModel : PageModel
{
    private ISkateService _service;
    public string SkateModelName { get; set; }
    public string CategoryName { get; set; }
    public string BrandName { get; set; }
    
    public SkateDetailsModel(ISkateService service)
    {
        _service = service;
    }
    
    public Skate Skate { get; private set; }
    
    public IActionResult OnGet(int id)
    {
        Skate = _service.GetSkate(id);

        if (Skate.SkateModelId is not null)
        {
            SkateModelName = _service.GetSkateModel(Skate.SkateModelId.Value).Name;
        }
        
        if (Skate.CategoryId is not null)
        {
            CategoryName = _service.GetCategory(Skate.CategoryId.Value).Name;
        }
        
        if (Skate.BrandId is not null)
        {
            BrandName = _service.GetBrand(Skate.BrandId.Value).Name;
        }

        if (Skate == null)
        {
            return NotFound();
        }

        return Page();
    }
}