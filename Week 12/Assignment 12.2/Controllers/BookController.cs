using Microsoft.AspNetCore.Mvc;
using Assignment_12._2.Models;

namespace Assignment_12._2.Controllers
{
    public class BookController : Controller
    {
        private IData _tempData;
        public BookController(IData tempData)
        {
            _tempData = tempData;
        }
        public IActionResult Details(int? id)
        {
            var model = _tempData.GetBook(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Books = _tempData.InitializeData();
            return View(model);
        }
    }
}
