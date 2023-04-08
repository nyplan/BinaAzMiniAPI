using BinaAzAPI.DTOs.PictureDTOs;
using BinaAzAPI.Entities;

namespace BinaAzAPI.DTOs.AdDTOs
{
    public record AdToAddDto
    {
        public int ApartmentTypeId { get; set; }
        public int ActionTypeId { get; set; }
        public int CityId { get; set; }
        public int RoomsId { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int NumberOfFloors { get; set; }
        public string AdditionalInformation { get; set; }
        public int Price { get; set; }
        public int PricePerDayMonthId { get; set; }
        public int RepairId { get; set; }
        public string Address { get; set; }
        public int DistrictId { get; set; }
        public int TownshipId { get; set; }
        public ICollection<PictureToAddDto> Pictures { get; set; }
        public string RelevantPerson { get; set; }
        public int AdOwnerId { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
