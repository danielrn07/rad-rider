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
    public SelectList CategoryOptionItems { get; set; }
    public SelectList TagOptionItems { get; set; }
    private ISkateService _service;

    public EditSkateModel(ISkateService service)
    {
        _service = service;
    }
    
    [BindProperty]
    public Skate Skate { get; set; }
    
    [BindProperty]
    public ICollection<int> SelectedTagIds { get; set; }
    
    public IActionResult OnGet(int id)
    {
        Skate = _service.GetSkate(id);

        SelectedTagIds = Skate.Tags.Select(tag => tag.TagId).ToList();
        
        BrandOptionItems = new SelectList(_service.GetAllBrands(),
            nameof(Brand.BrandId),
            nameof(Brand.Name));
        
        SkateModelOptionItems = new SelectList(_service.GetAllModels(),
            nameof(SkateModel.SkateModelId),
            nameof(SkateModel.Name));
        
        CategoryOptionItems = new SelectList(_service.GetAllCategories(),
            nameof(Category.CategoryId),
            nameof(Category.Name));
        
        TagOptionItems = new SelectList(_service.GetAllTags(),
            nameof(Tag.TagId),
            nameof(Tag.Name));

        if (Skate == null)
        {
            return NotFound();
        }
        
        return Page();
    }
    
    public IActionResult OnPost()
    {
        if (SelectedTagIds != null)
        {
            Skate.Tags = _service.GetAllTags()
                .Where(item => SelectedTagIds.Contains(item.TagId)).ToList();
        }
        
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