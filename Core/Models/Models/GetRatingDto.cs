

namespace Core.Models.Models
{
    public class GetRatingDto
    {
        public int Id { get; set; }
        public float RatingValue { get; set; }
        public int MediaId { get; set; }
    }
}