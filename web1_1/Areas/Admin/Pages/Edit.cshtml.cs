using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using web1_1.DAL.Entities;

namespace web1_1.Areas.Admin.Pages
{
    [Authorize(Roles = ("admin"))]
    public class EditModel : PageModel
    {
        private readonly web1_1.DAL.Data.ApplicationDbContext _context;
        private IWebHostEnvironment _environment;

        public EditModel(web1_1.DAL.Data.ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        [BindProperty]
        public Wheelchair Wheelchair { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

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
            ViewData["WheelchairGroupId"] = new SelectList(_context.WheelchairGroups, "WheelchairGroupId", "GroupName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Image != null)
            {
                var fileName = $"{Wheelchair.WheelchairId}" +
                Path.GetExtension(Image.FileName);
                Wheelchair.Image = fileName;
                var path = Path.Combine(_environment.WebRootPath, "Images",
                fileName);
                using (var fStream = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fStream);
                }
            }

            _context.Attach(Wheelchair).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!WheelchairExists(Wheelchair.WheelchairId))
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

        private bool WheelchairExists(int id)
        {
            return _context.Wheelchairs.Any(e => e.WheelchairId == id);
        }
    }
}
