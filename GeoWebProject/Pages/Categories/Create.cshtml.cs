using GeoWebProject.Data;
using GeoWebProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GeoWebProject.Pages.Categories
    
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "The Display Order cannot be exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
