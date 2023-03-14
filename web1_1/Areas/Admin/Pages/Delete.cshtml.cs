using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using web1_1.DAL.Entities;

namespace web1_1.Areas.Admin.Pages
{
    [Authorize(Roles = ("admin"))]
    public class DeleteModel : PageModel
    {
        private readonly web1_1.DAL.Data.ApplicationDbContext _context;

        public DeleteModel(web1_1.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wheelchair = await _context.Wheelchairs.FindAsync(id);

            if (Wheelchair != null)
            {
                _context.Wheelchairs.Remove(Wheelchair);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
