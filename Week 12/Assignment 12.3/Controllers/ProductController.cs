using Microsoft.AspNetCore.Mvc;
using Assignment_12._3.Models;
using System;

namespace Assignment_12._3.Controllers
{
    public class ProductController : Controller
    {
        private IData _tempData;
        public ProductController(IData tempdata)
        {
            _tempData = tempdata;
        }
        public IActionResult Details(int? id)
        {
            var model = _tempData.GetProduct(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _tempData.InitializeData();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            ViewBag.Servertime = DateTime.Now.ToString();
            //validation attributes
            if (ModelState.IsValid)
            {
                _tempData.AddProduct(obj);
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            _tempData.DeleteProduct(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Product obj = _tempData.GetProduct(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempData.UpdateProduct(obj);
            return RedirectToAction("Index");
        }
    }
}
