using Core;
using Entities.Enums;

namespace Entities
{
    public class Movie : BaseEntity
    {
        public string MovieName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

    }
}
