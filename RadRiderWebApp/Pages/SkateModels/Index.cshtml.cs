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
    public class IndexModel : PageModel
    {
        private readonly RadRiderWebApp.Data.SkateDbContext _context;

        public IndexModel(RadRiderWebApp.Data.SkateDbContext context)
        {
            _context = context;
        }

        public IList<SkateModel> SkateModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.SkateModel != null)
            {
                SkateModel = await _context.SkateModel.ToListAsync();
            }
        }
    }
}
