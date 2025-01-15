using Microsoft.AspNetCore.Mvc;
using PhotoShare.Models;

namespace PhotoShare.Controllers
{
    public class HomeController : Controller
    {
        // Contructor
        public HomeController()
        {            
        }

        // Home page - all photos
        public IActionResult Index()
        {
            // create a list of photos

            // create 3 photos

            // add to list

            return View();
        }

        // Photo page
        public IActionResult PhotoDetails(int id)
        {
            // create a photo
            Photo photo = new Photo();

            photo.PhotoId = id;
            photo.Title = "My cat";
            photo.Description = "A photo of my cat.";
            photo.CreatedAt = DateTime.Now;
            photo.ImageFilename = "cat.jpg";
            photo.IsPublic = true;

            return View();
        }

        // Privary page
        public IActionResult Privacy()
        {
            return View();
        }        
    }
}
