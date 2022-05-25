using Microsoft.AspNetCore.Mvc;

namespace BooksGallery.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
