using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class SkateDetailsModel : PageModel
{
    private ISkateService _service;
    
    public SkateDetailsModel(ISkateService service)
    {
        _service = service;
    }
    
    public Skate Skate { get; private set; }
    
    public IActionResult OnGet(int id)
    {
        Skate = _service.GetSkate(id);

        if (Skate == null)
        {
            return NotFound();
        }

        return Page();

    }
}