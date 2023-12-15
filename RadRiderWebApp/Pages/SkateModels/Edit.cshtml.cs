using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RadRiderWebApp.Data;
using RadRiderWebApp.Models;

namespace RadRiderWebApp.Pages.SkateModels
{
    public class EditModel : PageModel
    {
        private readonly RadRiderWebApp.Data.SkateDbContext _context;

        public EditModel(RadRiderWebApp.Data.SkateDbContext context)
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

            var skatemodel =  await _context.SkateModel.FirstOrDefaultAsync(m => m.SkateModelId == id);
            if (skatemodel == null)
            {
                return NotFound();
            }
            SkateModel = skatemodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SkateModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkateModelExists(SkateModel.SkateModelId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SkateModelExists(int id)
        {
          return (_context.SkateModel?.Any(e => e.SkateModelId == id)).GetValueOrDefault();
        }
    }
}
