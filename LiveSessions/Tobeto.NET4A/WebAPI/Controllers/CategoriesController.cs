using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Category category)
        {
            categoryService.Add(category);
        }
    }
}
