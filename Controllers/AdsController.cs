using AutoMapper;
using BinaAzAPI.DAL;
using BinaAzAPI.DTOs.AdDTOs;
using BinaAzAPI.DTOs.PictureDTOs;
using BinaAzAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BinaAzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public AdsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("Advanced")]
        public IActionResult Search([FromQuery] AdSearchObject search)
        {
            if (_context.Ads.Any(c => c.AdNumber == search.AdNumber))
            {
                AdToListDto dto = _mapper.Map<AdToListDto>(_context.Ads
                    .Include(c => c.Township)
                    .Include(c => c.District)
                    .Include(c => c.City)
                    .Include(c => c.ApartmentType)
                    .Include(c => c.ActionType)
                    .Include(c => c.Rooms)
                    .Include(c => c.PricePerDayMonth)
                    .Include(c => c.Repair)
                    .Include(c => c.AdOwner)
                    .Include(c => c.Pictures)
                    .AsNoTracking()
                    .First(c => c.AdNumber == search.AdNumber));
                return Ok(dto);
            }
            IQueryable<Ad> entities = _context.Ads.Where(ad =>
            (search.ActionTypeId != 0 ? ad.ActionTypeId == search.ActionTypeId : true) &&
            (search.ApartmentTypeId != 0 ? ad.ApartmentTypeId == search.ApartmentTypeId : true) &&
            (search.RoomsId != 0 ? ad.RoomsId == search.RoomsId : true) &&
            (search.MinPrice != 0 ? ad.Price >= search.MinPrice : true) &&
            (search.MaxPrice != 0 ? ad.Price <= search.MaxPrice : true) &&
            (search.CityId != 0 ? ad.CityId == search.CityId : true) &&
            (search.RepairId != 0 ? ad.RepairId == search.RepairId : true) &&
            (search.MinArea != 0 ? ad.Area >= search.MinArea : true) &&
            (search.MaxArea != 0 ? ad.Area <= search.MaxArea : true) &&
            (search.MinFloor != 0 ? ad.Floor >= search.MinFloor : true) &&
            (search.MaxFloor != 0 ? ad.Floor <= search.MaxFloor : true) &&
            (search.DontBeThe1st ? ad.Floor >= 1 : true) &&
            (search.DontBeTheTop ? ad.Floor <= ad.NumberOfFloors : true) &&
            (search.OnlyTheTop ? ad.Floor == ad.NumberOfFloors : true) &&
            (search.DistrictId != 0 ? ad.DistrictId == search.DistrictId : true) &&
            (search.TownshipId != 0 ? ad.TownshipId == search.TownshipId : true) &&
            (search.TownshipId != 0 ? ad.TownshipId == search.TownshipId : true) &&
            (search.PricePerDayMonthId != 0 ? ad.PricePerDayMonthId == search.PricePerDayMonthId : true))
                .Include(c => c.Township)
                .Include(c => c.District)
                .Include(c => c.City)
                .Include(c => c.ApartmentType)
                .Include(c => c.ActionType)
                .Include(c => c.Rooms)
                .Include(c => c.PricePerDayMonth)
                .Include(c => c.Repair)
                .Include(c => c.AdOwner)
                .Include(c => c.Pictures)
                .AsNoTracking();

            IEnumerable<AdToListDto> dtos = _mapper.Map<IEnumerable<AdToListDto>>(entities);

            return Ok(dtos);
        }
        [HttpGet]
        public IActionResult GetAds()
        {
            IQueryable<Ad> entities = _context.Ads
                .Include(c => c.Township)
                .Include(c => c.District)
                .Include(c => c.City)
                .Include(c => c.ApartmentType)
                .Include(c => c.ActionType)
                .Include(c => c.Rooms)
                .Include(c => c.PricePerDayMonth)
                .Include(c => c.Repair)
                .Include(c => c.AdOwner)
                .Include(c => c.Pictures)
                .AsNoTracking();
            IEnumerable<AdToListDto> dtos = _mapper.Map<IEnumerable<AdToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult GetAdById([FromRoute] int id)
        {
            Ad entity = _context.Ads
                .Include(c => c.Township)
                .Include(c => c.District)
                .Include(c => c.City)
                .Include(c => c.ApartmentType)
                .Include(c => c.ActionType)
                .Include(c => c.Rooms)
                .Include(c => c.PricePerDayMonth)
                .Include(c => c.Repair)
                .Include(c => c.AdOwner)
                .Include(c => c.Pictures)
                .AsNoTracking()
                .First(c => c.Id == id);
            AdByIdDto dto = _mapper.Map<AdByIdDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromBody] AdToAddDto dto)
        {
            Ad entity = _mapper.Map<Ad>(dto);
            entity.AdNumber = _context.Ads.OrderBy(a => a.AdNumber).LastOrDefault()?.AdNumber + 1 ?? 1;
            _context.Ads.Add(entity);
            _context.SaveChanges();
            return Ok(dto);
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromQuery] AdToUpdateDto dto)
        {
            Ad entity = _mapper.Map<Ad>(dto);
            entity.Id = id;
            entity.AdNumber = _context.Ads.AsNoTracking().First(c => c.Id == id).AdNumber;
            _context.Ads.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            Ad entity = _context.Ads.Find(id);
            _context.Ads.Remove(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        
    }
}
