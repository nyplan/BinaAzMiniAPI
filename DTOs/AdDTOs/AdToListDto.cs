using BinaAzAPI.DTOs.PictureDTOs;
using BinaAzAPI.Entities;

namespace BinaAzAPI.DTOs.AdDTOs
{
    public record AdToListDto
    {
        public int Id { get; set; }
        public int AdNumber { get; set; }
        public string ApartmentType { get; set; }
        public string ActionType { get; set; }
        public string City { get; set; }
        public string Rooms { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int NumberOfFloors { get; set; }
        public string AdditionalInformation { get; set; }
        public int Price { get; set; }
        public string PricePerDayMonth { get; set; }
        public string Repair { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Township { get; set; }
        public ICollection<PictureToListDto> Pictures { get; set; }
        public string RelevantPerson { get; set; }
        public string AdOwner { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
