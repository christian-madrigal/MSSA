using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Assignment_13._2._1.Models;
namespace Assignment_13._2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> product = new List<Product>();
        public ProductController()
        {
            product.Add(new Product() 
            { 
                Id = 101, 
                Name = "Jordan Retro 11", 
                Description = "The Air Jordan 11 Cool Grey (2021) features a Cool Grey Durabuck upper with patent leather overlays and a signature Jumpman embroidery on the collar. ", 
                Price = 190, });
            product.Add (new Product() 
            { 
                Id = 102, 
                Name = "Yeezy Wave Runners", 
                Description = "The Yeezy 700 Boost Wave Runner is the shoe that led Yeezy's pivot from a sleek, minimal aesthetic to a chunky, 90s inspired one. ", 
                Price = 300, });
            product.Add(new Product() 
            { 
                Id = 103, 
                Name = "Yeezy Ochre Foam RNNR", 
                Description = "The adidas Yeezy Foam RNNR Ochre features a golden Ochre one-piece EVA foam construction. Oval cut-outs throughout the design provide ventilation, while a cushioned footbed offers support. ", 
                Price = 90, });
            product.Add(new Product() 
            { 
                Id = 104, 
                Name = "Jordan Retro 4 Oreos", 
                Description = "The Air Jordan 4 Retro White Oreo features a white leather and mesh upper with hits of Tech Grey on its eyelets and midsole. From there, a red Jumpman logo is embroidered on the tongue, adding a pop of color to the neutral-toned design. ", 
                Price = 190, });
        }
        [HttpGet()]
        public List<Product> GetProducts()
        {
            return this.product;
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductbyId(int id)
        {
            var product = this.product.Find(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
