using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class InsertSkateModel : PageModel
{
    public SelectList BrandOptionItems { get; set; }
    public SelectList SkateModelOptionItems { get; set; }
    public SelectList CategoryOptionItems { get; set; }
    private ISkateService _service;
    
    public InsertSkateModel(ISkateService service)
    {
        _service = service;
    }

    public void OnGet()
    {
        BrandOptionItems = new SelectList(_service.GetAllBrands(),
             nameof(Brand.BrandId),
            nameof(Brand.Name));
        
        SkateModelOptionItems = new SelectList(_service.GetAllModels(),
            nameof(SkateModel.SkateModelId),
            nameof(SkateModel.Name));
        
        CategoryOptionItems = new SelectList(_service.GetAllCategories(),
            nameof(Category.CategoryId),
            nameof(Category.Name));
    }
    
    [BindProperty]
    public Skate Skate { get; set; }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _service.InsertSkate(Skate);

        return RedirectToPage("/Index");
    }
}