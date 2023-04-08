using AutoMapper;
using BinaAzAPI.DAL;
using BinaAzAPI.DTOs.PictureDTOs;
using BinaAzAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BinaAzAPI.Controllers
{
    [Route("api/Ad/{id}/[controller]")]
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public PicturesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get([FromRoute] int id)
        {
            IQueryable<Picture> entities = _context.Pictures.Where(c => c.AdId == id);
            IEnumerable<PictureToListDto> dtos = _mapper.Map<IEnumerable<PictureToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpPost]
        public IActionResult Post([FromRoute] int id, [FromBody] List<PictureToAddDto> dto)
        {
            List<Picture> pics = _mapper.Map<List<Picture>>(dto);
            pics.ForEach(c => c.AdId = id);
            _context.Pictures.AddRange(pics);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id, [FromBody] List<int> ids)
        {
            IQueryable<Picture> entities = _context.Pictures.Where(c => c.AdId == id && ids.Contains(c.Id));
            _context.Pictures.RemoveRange(entities);
            _context.SaveChanges();
            return Ok();
        }
    }
}
