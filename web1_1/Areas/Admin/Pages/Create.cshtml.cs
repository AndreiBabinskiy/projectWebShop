using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Threading.Tasks;
using web1_1.DAL.Entities;

namespace web1_1.Areas.Admin.Pages
{
    [Authorize(Roles = ("admin"))]
    public class CreateModel : PageModel
    {
        private readonly web1_1.DAL.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public CreateModel(web1_1.DAL.Data.ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        public IActionResult OnGet()
        {
            ViewData["WheelchairGroupId"] = new SelectList(_context.WheelchairGroups, "WheelchairGroupId", "GroupName");
            return Page();
        }

        [BindProperty]
        public Wheelchair Wheelchair { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Wheelchairs.Add(Wheelchair);
            await _context.SaveChangesAsync();

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
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
