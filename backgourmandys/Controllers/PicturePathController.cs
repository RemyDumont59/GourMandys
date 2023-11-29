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

        #region Create
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PicturePath picturePath)
        {
            var createdAtId = await _picturePathRepository.Add(picturePath);

            if (createdAtId > 0)
                return CreatedAtAction(nameof(GetById), new { id = createdAtId }, "PicturePath Added !");
            return BadRequest("Something went wrong...");
        }
        #endregion 

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

        #region Update
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] PicturePath picturePath)
        {
            var picturePathFromDb = _picturePathRepository.GetById(id);

            if (picturePathFromDb == null)
                return NotFound("There is no PicturePath with this Id.");

            picturePath.Id = id;

            if (await _picturePathRepository.Update(picturePath))
                return Ok("PicturePath Updated.");

            return BadRequest("Something went wrong...");
        }
        #endregion Update

        #region Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _picturePathRepository.Delete(id))
                return Ok("PicturePath Deleted.");
            return NotFound("PicturePath Not Found.");
        }
        #endregion Delete
    }
}
