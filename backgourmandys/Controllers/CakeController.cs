using backgourmandys.Models;
using backgourmandys.Repositories;
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

        // En construction
        [HttpPost]
        public async Task<IActionResult> Create(Cake cake)
        {
            if( await _cakeRepository.Add(cake) == 0)
            {
                return BadRequest();
            }

            return Ok(new
            {
                Message = "Cake ajouté avec succé",
                CakeId = cake.Id,
            });
        }

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


    }
}
