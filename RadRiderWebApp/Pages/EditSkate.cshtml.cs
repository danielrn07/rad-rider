using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class EditSkateModel : PageModel
{
    public SelectList BrandOptionItems { get; set; }
    public SelectList SkateModelOptionItems { get; set; }
    private ISkateService _service;

    public EditSkateModel(ISkateService service)
    {
        _service = service;
    }
    
    [BindProperty]
    public Skate Skate { get; set; }
    
    public IActionResult OnGet(int id)
    {
        Skate = _service.GetSkate(id);
        
        BrandOptionItems = new SelectList(_service.GetAllBrands(),
            nameof(Brand.BrandId),
            nameof(Brand.Name));
        
        SkateModelOptionItems = new SelectList(_service.GetAllModels(),
            nameof(SkateModel.SkateModelId),
            nameof(SkateModel.Name));

        if (Skate == null)
        {
            return NotFound();
        }

        return Page();
    }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        _service.EditSkate(Skate);

        return RedirectToPage("/Index");

    }

    public IActionResult OnPostDelete()
    {
        _service.DeleteSkate(Skate.Id);
        return RedirectToPage("/Index");
    }
}