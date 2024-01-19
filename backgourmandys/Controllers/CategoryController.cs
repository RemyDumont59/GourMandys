using backgourmandys.Models;
using backgourmandys.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace backgourmandys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {

        private readonly IRepository<Category> _categoryRepository;

        public CategoryController(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (await _categoryRepository.Add(category) == 0)
            {
                return BadRequest();
            }

            return Ok(new
            {
                Message = "Catégorie ajouté avec succès",
                CategoryId = category.Id,
            });
        }

        #region Read

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Category> categorys = await _categoryRepository.GetAll();

            return Ok(categorys);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryRepository.GetById(id);

            if (category == null)
                return NotFound(new
                {
                    Message = "There is no Category with this Id."
                });

            return Ok(new
            {
                Message = "Category found.",
                Category = category,
            });
        }

        #endregion Read
    }
}

