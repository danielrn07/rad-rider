using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RadRiderWebApp.Data;
using RadRiderWebApp.Models;

namespace RadRiderWebApp.Pages.SkateModels
{
    public class DeleteModel : PageModel
    {
        private readonly RadRiderWebApp.Data.SkateDbContext _context;

        public DeleteModel(RadRiderWebApp.Data.SkateDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public SkateModel SkateModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SkateModel == null)
            {
                return NotFound();
            }

            var skatemodel = await _context.SkateModel.FirstOrDefaultAsync(m => m.SkateModelId == id);

            if (skatemodel == null)
            {
                return NotFound();
            }
            else 
            {
                SkateModel = skatemodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.SkateModel == null)
            {
                return NotFound();
            }
            var skatemodel = await _context.SkateModel.FindAsync(id);

            if (skatemodel != null)
            {
                SkateModel = skatemodel;
                _context.SkateModel.Remove(SkateModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
