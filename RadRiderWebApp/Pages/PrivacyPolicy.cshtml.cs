using Microsoft.AspNetCore.Mvc.RazorPages;
namespace RadRiderWebApp.Pages;

public class PrivacyPolicy : PageModel
{
    private readonly ILogger<PrivacyPolicy> _logger;

    public PrivacyPolicy(ILogger<PrivacyPolicy> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}