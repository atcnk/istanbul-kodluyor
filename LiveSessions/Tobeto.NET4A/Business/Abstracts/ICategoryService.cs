using Entities;

namespace Business.Abstracts
{
    public interface ICategoryService
    {    
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        Category GetById(int id);
        List<Category> GetAll();
    }
}
