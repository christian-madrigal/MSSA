using Microsoft.AspNetCore.Mvc;
using Assignment_13._3.Models;
using Assignment_13._3.Filters;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Assignment_13._3.Controllers
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
        [SimpleActionFilter]
        [Authorize(Roles ="Customer")]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _tempData.InitializeData();
            return View(model);
        }
        [Authorize()]
        public IActionResult Create()
        {
            //ViewBag.Servertime = DateTime.Now.ToString();
            return View();
        }
        [HttpPost]
        [Authorize(Roles ="Admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            //ViewBag.Servertime = DateTime.Now.ToString();
            //validation attributes
            if (ModelState.IsValid)
            {
                _tempData.AddProduct(obj);
            }
            return View();
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            _tempData.DeleteProduct(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            Product obj = _tempData.GetProduct(id);
            return View(obj);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempData.UpdateProduct(obj);
            return RedirectToAction("Index");
        }
    }
}
