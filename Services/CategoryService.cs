using BusinessObjects.Model;
using Repositories;

namespace Services
{
    public class CategoryService : ICatergoryService
    {
        private readonly ICatergoryRepository iCategoryRepository;
        public List<Category> GetCategories()
        {
            return iCategoryRepository.GetCategories();
        }
        public CategoryService()
        {
            iCategoryRepository = new CategoryRepository();
        }
    }
}
