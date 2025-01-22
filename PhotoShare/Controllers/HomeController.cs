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

            // create 3 photos
            Photo photo1 = new Photo();
            photo1.PhotoId = 1;
            photo1.Description = "A photo of my dog.";
            photo1.CreatedAt = DateTime.Now;
            photo1.ImageFilename = "dog.jpg";

            Photo photo2 = new Photo();
            photo2.PhotoId = 2;
            photo2.Description = "A photo of my cat.";
            photo2.CreatedAt = DateTime.Now;
            photo2.ImageFilename = "cat.jpg";

            Photo photo3 = new Photo();
            photo3.PhotoId = 3;
            photo3.Description = "A photo of my parrot.";
            photo3.CreatedAt = DateTime.Now;
            photo3.ImageFilename = "parrot.jpg";

            // add to list
            photos.Add(photo1);
            photos.Add(photo2);
            photos.Add(photo3);

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
