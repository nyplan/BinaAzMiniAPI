using BinaAzAPI.Entities;

namespace BinaAzAPI.DTOs.PictureDTOs
{
    public record PictureToAddDto
    {
        public string Url { get; set; }
        public int AdId { get; set; }
    }
}
