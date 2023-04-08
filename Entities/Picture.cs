namespace BinaAzAPI.Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int AdId { get; set; }
        public Ad Ad { get; set; }
    }
}
