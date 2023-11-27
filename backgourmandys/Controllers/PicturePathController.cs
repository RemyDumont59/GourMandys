using backgourmandys.Models;
using backgourmandys.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace backgourmandys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturePathController : ControllerBase
    {
        private readonly IRepository<PicturePath> _picturePathRepository;

        public PicturePathController(IRepository<PicturePath> picturePathRepository)
        {
            _picturePathRepository = picturePathRepository;
        }

        // En construction
        #region Create

        #endregion Create

        #region Read

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<PicturePath> picturePaths = await _picturePathRepository.GetAll();

            return Ok(picturePaths);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var picturePath = await _picturePathRepository.GetById(id);

            if (picturePath == null)
                return NotFound(new
                {
                    Message = "There is no PicturePath with this Id."
                });

            return Ok(new
            {
                Message = "PicturePath found.",
                PicturePath = picturePath,
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
