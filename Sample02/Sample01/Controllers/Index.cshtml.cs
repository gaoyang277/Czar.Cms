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
    public class IndexModel : PageModel
    {
        private readonly Sample01.Models.Sample01Context _context;

        public IndexModel(Sample01.Models.Sample01Context context)
        {
            _context = context;
        }

        public IList<Content> Content { get;set; }

        public async Task OnGetAsync()
        {
            Content = await _context.Content.ToListAsync();
        }
    }
}
