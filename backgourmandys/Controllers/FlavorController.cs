using backgourmandys.Models;
using backgourmandys.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace backgourmandys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlavorController : ControllerBase
    {
        private readonly IRepository<Flavor> _flavorRepository;

        public FlavorController(IRepository<Flavor> flavorRepository)
        {
            _flavorRepository = flavorRepository;
        }

        // En construction
        [HttpPost]
        public async Task<IActionResult> Create(Flavor flavor)
        {
            if (await _flavorRepository.Add(flavor) == 0)
            {
                return BadRequest();
            }

            return Ok(new
            {
                Message = "Parfum ajouté avec succès",
                FlavorId = flavor.Id,
            });
        }

        #region Read

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Flavor> flavors = await _flavorRepository.GetAll();

            return Ok(flavors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var flavor = await _flavorRepository.GetById(id);

            if (flavor == null)
                return NotFound(new
                {
                    Message = "There is no Flavor with this Id."
                });

            return Ok(new
            {
                Message = "Flavor found.",
                Flavor = flavor,
            });
        }

        #endregion Read
    }
}
