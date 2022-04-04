using System.Collections.Generic;
namespace Assignment_12._3.Models
{
    public interface IData
    {
        List<Product> Products { get; set; }
        List<Product> InitializeData();
        Product GetProduct(int? id);
        void AddProduct(Product product);
        void DeleteProduct(int? product);
        void UpdateProduct(Product product);
    }
}
