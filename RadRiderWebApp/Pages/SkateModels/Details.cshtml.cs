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
    public class DetailsModel : PageModel
    {
        private readonly RadRiderWebApp.Data.SkateDbContext _context;

        public DetailsModel(RadRiderWebApp.Data.SkateDbContext context)
        {
            _context = context;
        }

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
    }
}
