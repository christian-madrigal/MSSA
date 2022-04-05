using System.Collections.Generic;

namespace Assignment_13._2.Models
{
    public class DBData : IData
    {
        public List<Product> Products { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        private ProductContext _productContext;
        public DBData(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public void AddProduct(Product product)
        {

            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public void DeleteProduct(int? id)
        {
            var prod = _productContext.Products.Find(id);
            if (prod != null)
            {
                _productContext.Products.Remove(prod);
                _productContext.SaveChanges();
            }

        }

        public Product GetProduct(int? id)
        {
            return _productContext.Products.Find(id);
        }

        public IEnumerable<Product> InitializeData()
        {
            return _productContext.Products;
        }

        public void UpdateProduct(Product product)
        {
            Product prod = _productContext.Products.Find(product.Id);
            if (product != null)
            {
                prod.Id = prod.Id;
                prod.Name = prod.Name;
                prod.Description = prod.Description;
                prod.Price = prod.Price;
                prod.ImageName = prod.ImageName;
                _productContext.SaveChanges();
            }
        }
    }
}
