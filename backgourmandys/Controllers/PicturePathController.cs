using backgourmandys.DTOs;
using backgourmandys.Interfaces;
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
        private readonly IPictureService _pictureService;

        public PicturePathController(IRepository<PicturePath> picturePathRepository, IPictureService pictureService)
        {
            _picturePathRepository = picturePathRepository;
            _pictureService = pictureService;
        }

        // En construction
        // #region Create
        //
        // #endregion Create
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreatePicturePathDto createPicturePathDto)
        {
            if (ModelState.IsValid)
            {
                    var result = await _pictureService.AddPhotoAsync(createPicturePathDto.FormFile!);
                    var thePicturePath = new PicturePath()
                    {
                        Path = result.Url.ToString(),
                        CakeId = createPicturePathDto.CakeId,
                    };
                    if (await _picturePathRepository.Add(thePicturePath) == 0)
                    {
                        return BadRequest("bad request");
                    }

                    return Ok(new
                    {
                        Message = "image uploaded successfully",
                        formFile = thePicturePath,
                    });
            }
            else
            {
                ModelState.AddModelError("", "Picture upload failed");
            }

            return NotFound("unable to find the picture");
        }

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
        // #region Update
        //
        // #endregion Update

        // En construction
        // #region Delete
        //
        // #endregion Delete
    }
}
