using Microsoft.AspNetCore.Mvc.RazorPages;
using RadRiderWebApp.Models;
using RadRiderWebApp.Services;

namespace RadRiderWebApp.Pages;

public class IndexModel : PageModel
{
    private ISkateService _service;

    public IndexModel(ISkateService service)
    {
        _service = service;
    }
    public IList<Skate> SkateList { get; set; }
    public void OnGet()
    {
        SkateList = _service.GetAll();
    }
}