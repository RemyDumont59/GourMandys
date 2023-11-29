using backgourmandys.Models;
using backgourmandys.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backgourmandys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        private readonly IRepository<Cake> _cakeRepository;

        public CakeController(IRepository<Cake> cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        #region Create
        [HttpPost]
        public async Task<IActionResult> Create(Cake cake)
        {
            int result = await _cakeRepository.Add(cake);
            if(result == 0)
            {
                return BadRequest();
            }
            return Ok();           
        }

        #endregion Create
        
        #region Read

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Cake> cakes = await _cakeRepository.GetAll();

            return Ok(cakes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cake = await _cakeRepository.GetById(id);

            if (cake == null)
                return NotFound(new
                {
                    Message = "There is no Cake with this Id."
                });

            return Ok(new
            {
                Message = "Cake found.",
                Cake = cake,
            });
        }

        #endregion Read
        
        // En construction
        #region Update

        #endregion Update
        
        // En construction
        #region Delete

        #endregion Delete

    }
}
