using BusinessObjects.Model;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);

        public Product GetProductById(int id) => ProductDAO.GetProductByID(id);

        public List<Product> GetProducts() => ProductDAO.getProduct();

        public void SaveProduct(Product product) => ProductDAO.SaveProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Update(product);
    }
}
