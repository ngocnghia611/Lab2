using BusinessObjects;
using BusinessObjects.Model;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        public static List<Product> getProduct()
        {
            List<Product> products = new List<Product>();
            try
            {
                using var context = new MyStoreContext();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {

            }
            return products;
        }
        public static void SaveProduct(Product product)
        {

            try
            {
                using var context = new MyStoreContext();
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteProduct(Product product)
        {
            try
            {
                using var context = new MyStoreContext();
                var p1 = context.Products.SingleOrDefault(c => c.ProductId == product.ProductId);
                context.Products.Remove(p1);
            }
            catch (Exception ex) { }

        }
        public static void Update(Product product)
        {
            {
                try
                {
                    using var context = new MyStoreContext();
                    context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public static Product GetProductByID(int id)
        {
            using var db = new MyStoreContext();
            return db.Products.FirstOrDefault(c => c.ProductId.Equals(id));
        }
    }
}
