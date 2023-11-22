using Microsoft.AspNetCore.Mvc.RazorPages;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class SkateDetailsModel : PageModel
{
    
    public Skate Skate { get; private set; }
    
    public void OnGet(int id)
    {
        var service = new SkateService();
        Skate = service.GetSkate(id);

    }
}