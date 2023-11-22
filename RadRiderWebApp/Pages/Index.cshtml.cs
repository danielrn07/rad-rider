using Microsoft.AspNetCore.Mvc.RazorPages;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class IndexModel : PageModel
{
    public IList<Skate> SkateList { get; set; }
    public void OnGet()
    {
        var service = new SkateService();
        SkateList = service.GetAll();
    }
}