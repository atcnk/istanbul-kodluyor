using Business.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        List<Category> categories;

        public CategoryManager()
        {
            this.categories = new List<Category>();
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int id)
        {
            categories.Remove(GetById(id));
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);           
        }

        public void Update(Category category)
        {
            Category existingCategory = GetById(category.Id);

            if (existingCategory is not null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
            }
            else
            {
                throw new ArgumentException("Guncellenecek bir kategori bulunamadi.");
            }
        }
    }
}
