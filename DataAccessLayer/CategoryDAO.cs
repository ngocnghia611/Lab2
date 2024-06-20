using BusinessObjects;
using BusinessObjects.Model;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            var list = new List<Category>();
            try
            {
                using var context = new MyStoreContext();
                list = context.Categories.ToList();
            }
            catch (Exception ex)
            {

            }
            return list;

        }
    }
}
