using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class DetailsModel : PageModel
    {
        private readonly Sample01.Models.Sample01Context _context;

        public DetailsModel(Sample01.Models.Sample01Context context)
        {
            _context = context;
        }

        public Content Content { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Content = await _context.Content.FirstOrDefaultAsync(m => m.Id == id);

            if (Content == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
