namespace BinaAzAPI.Entities
{
    public class AdSearchObject
    {
        public int ActionTypeId { get; set; }
        public int ApartmentTypeId { get; set; }
        public int RoomsId { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int CityId { get; set; }
        public int RepairId { get; set; }
        public int MinArea { get; set; }
        public int MaxArea { get; set; }
        public int MinFloor { get; set; }
        public int MaxFloor { get; set; }
        public bool DontBeThe1st { get; set; }
        public bool DontBeTheTop { get; set; }
        public bool OnlyTheTop { get; set; }
        public int DistrictId { get; set; }
        public int TownshipId { get; set; }
        public int PricePerDayMonthId { get; set; }
        public int AdNumber { get; set; }
    }
}
