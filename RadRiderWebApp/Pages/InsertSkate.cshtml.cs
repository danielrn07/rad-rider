using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class InsertSkateModel : PageModel
{
    private ISkateService _service;
    
    public InsertSkateModel(ISkateService service)
    {
        _service = service;
    }
    
    [BindProperty]
    public Skate Skate { get; set; }
    
    public IActionResult OnGet(int id)
    {
        Skate = _service.GetSkate(id);

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
        
        _service.InsertSkate(Skate);

        return RedirectToPage("/Index");

    }
}