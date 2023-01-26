using System.Collections.Generic;
using Project2023.Shared.Domain;

namespace Project2023.Server.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

        IEnumerable<Product> GetProductsByCategory(int categoryId);
        IEnumerable<Product> SearchProductsByName(string name);
        IEnumerable<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice);
    }
}
