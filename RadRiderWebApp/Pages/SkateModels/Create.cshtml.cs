using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadRiderWebApp.Data;
using RadRiderWebApp.Models;

namespace RadRiderWebApp.Pages.SkateModels
{
    public class CreateModel : PageModel
    {
        private readonly RadRiderWebApp.Data.SkateDbContext _context;

        public CreateModel(RadRiderWebApp.Data.SkateDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SkateModel SkateModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.SkateModel == null || SkateModel == null)
            {
                return Page();
            }

            _context.SkateModel.Add(SkateModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
