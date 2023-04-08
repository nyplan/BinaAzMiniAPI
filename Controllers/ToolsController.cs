using AutoMapper;
using BinaAzAPI.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BinaAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ToolsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("Cities")]
        public IActionResult GetCities()
        {
            return Ok(_context.Cities.AsNoTracking());
        }
        [HttpGet("City/{id}/Districts")]
        public IActionResult GetDistricts([FromRoute] int id)
        {
            return Ok(_context.Districts.Where(c => c.CityId == id).AsNoTracking());
        }
        [HttpGet("District/{id}/Townships")]
        public IActionResult GetTownships([FromRoute] int id)
        {
            return Ok(_context.Townships.Where(c => c.DistrictId == id).AsNoTracking());
        }
        [HttpGet("ApartmentTypes")]
        public IActionResult GetApartmentTypes()
        {
            return Ok(_context.EnumValues.Where(c => c.KeyId == 1).AsNoTracking());
        }
        [HttpGet("ActionTypes")]
        public IActionResult GetActionTypes()
        {
            return Ok(_context.EnumValues.Where(c => c.KeyId == 2).AsNoTracking());
        }
        [HttpGet("Rooms")]
        public IActionResult GetRooms()
        {
            return Ok(_context.EnumValues.Where(c => c.KeyId == 3).AsNoTracking());
        }
        [HttpGet("PricePerDayMonth")]
        public IActionResult GetPricePerDayMonth()
        {
            return Ok(_context.EnumValues.Where(c => c.KeyId == 4).AsNoTracking());
        }
        [HttpGet("Repair")]
        public IActionResult GetRepair()
        {
            return Ok(_context.EnumValues.Where(c => c.KeyId == 5).AsNoTracking());
        }
        [HttpGet("AdOwner")]
        public IActionResult GetAdOwner()
        {
            return Ok(_context.EnumValues.Where(c => c.KeyId == 6).AsNoTracking());
        }
    }
}
