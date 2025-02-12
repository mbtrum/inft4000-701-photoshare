using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhotoShareContext _context;

        // Contructor
        public HomeController(PhotoShareContext context)
        {
            _context = context;
        }

        // Home page - all photos - ../ or ../Home/Index
        public async Task<IActionResult> Index()
        {
            // get a list of all photos from db
            var photos = await _context.Photo.ToListAsync();

            // pass photos object into View
            return View(photos);
        }

        // Photo page - one photo (by id) - ../Home/PhotoDetails/589
        public async Task<IActionResult> PhotoDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // get photo by id
            var photo = await _context.Photo
                .Include(m => m.Tags)
                .FirstOrDefaultAsync(m => m.PhotoId == id);

            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // Privary page
        public IActionResult Privacy()
        {
            return View();
        }        
    }
}
