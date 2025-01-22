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

        // Home page - all photos - ../ or ../Home/Index
        public IActionResult Index()
        {
            // create a list of photos
            List<Photo> photos = new List<Photo>();


            // Pass photos object into View
            return View(photos);
        }

        // Photo page - one photo (by id) - ../Home/PhotoDetails/589
        public IActionResult PhotoDetails(int id)
        {
            // create a photo
            Photo photo = new Photo();

            photo.PhotoId = id;
            photo.Description = "A photo of my hamster.";
            photo.CreatedAt = DateTime.Now;
            photo.ImageFilename = "hamster.jpg";
            photo.IsVisible = true;

            // Pass photo object into View
            return View(photo);
        }

        // Privary page
        public IActionResult Privacy()
        {
            return View();
        }        
    }
}
