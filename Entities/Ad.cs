using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace BinaAzAPI.Entities
{
    public class Ad
    {
        public int Id { get; set; }
        public int AdNumber { get; set; }
        public int ApartmentTypeId { get; set; }
        public EnumValue ApartmentType { get; set; }
        public int ActionTypeId { get; set; }
        public EnumValue ActionType { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int RoomsId { get; set; }
        public EnumValue Rooms { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int NumberOfFloors { get; set; }
        public string AdditionalInformation { get; set; }
        public int Price { get; set; }
        public int PricePerDayMonthId { get; set; }
        public EnumValue PricePerDayMonth { get; set; }
        public int RepairId { get; set; }
        public EnumValue Repair { get; set; }
        public string Address { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int TownshipId { get; set; }
        public Township Township { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public string RelevantPerson { get; set; }
        public int AdOwnerId { get; set; }
        public EnumValue AdOwner { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
