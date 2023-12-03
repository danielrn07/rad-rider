using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class InsertSkateModel : PageModel
{
    public SelectList BrandOptionItems { get; set; }
    public SelectList SkateModelOptionItems { get; set; }
    public SelectList CategoryOptionItems { get; set; }
    public SelectList TagOptionItems { get; set; }
    private ISkateService _service;
    private IToastNotification _toastNotification;
    
    public InsertSkateModel(ISkateService service, IToastNotification toastNotification)
    {
        _service = service;
        _toastNotification = toastNotification;
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
        
        TagOptionItems = new SelectList(_service.GetAllTags(),
            nameof(Tag.TagId),
            nameof(Tag.Name));
    }
    
    [BindProperty]
    public Skate Skate { get; set; }
    
    [BindProperty]
    public ICollection<int> SelectedTagIds { get; set; }
    
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

        try
        {
            _service.InsertSkate(Skate);
            _toastNotification.AddSuccessToastMessage("Skate adicionado com sucesso.");
        }
        catch (Exception e)
        {
            _toastNotification.AddErrorToastMessage("Não foi possível adicionar o skate. Tente novamente.");
        }
        
    
        return RedirectToPage("/Index");
    }
}