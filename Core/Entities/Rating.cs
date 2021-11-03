

using System;

namespace Core.Entities
{
    public class Rating : BaseEntity
    {
        public int Id { get; set; }
        public float RatingValue { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}