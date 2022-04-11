using System.Collections.Generic;
namespace Assignment_13._3.Models
{
    public interface IData
    {
        List<Product> Products { get; set; }
        IEnumerable<Product> InitializeData();
        Product GetProduct(int? id);
        void AddProduct(Product product);
        void DeleteProduct(int? product);
        void UpdateProduct(Product product);
    }
}
