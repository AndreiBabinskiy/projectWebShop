using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using web1_1.DAL.Entities;

namespace web1_1.Areas.Admin.Pages
{
    [Authorize(Roles = ("admin"))]
    public class DetailsModel : PageModel
    {
        private readonly web1_1.DAL.Data.ApplicationDbContext _context;

        public DetailsModel(web1_1.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Wheelchair Wheelchair { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wheelchair = await _context.Wheelchairs
                .Include(w => w.Group).FirstOrDefaultAsync(m => m.WheelchairId == id);

            if (Wheelchair == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
