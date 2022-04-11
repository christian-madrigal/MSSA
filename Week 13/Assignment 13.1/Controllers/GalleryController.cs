using Microsoft.AspNetCore.Mvc;

namespace Assignment_13._1.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
