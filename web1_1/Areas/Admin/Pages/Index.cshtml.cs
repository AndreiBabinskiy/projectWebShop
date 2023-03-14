using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using web1_1.DAL.Entities;

namespace web1_1.Areas.Admin.Pages
{
    [Authorize(Roles = ("admin"))]
    public class IndexModel : PageModel
    {
        private readonly web1_1.DAL.Data.ApplicationDbContext _context;

        public IndexModel(web1_1.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Wheelchair> Wheelchair { get; set; }

        public async Task OnGetAsync()
        {
            Wheelchair = await _context.Wheelchairs
                .Include(w => w.Group).ToListAsync();
        }
    }
}
