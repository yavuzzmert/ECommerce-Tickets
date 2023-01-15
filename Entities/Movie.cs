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


        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }


        public int ProducerId { get; set; }
        public Producer Producer { get; set; }


        public ICollection<Actor> Actors { get; set; }

        public Movie()
        {
            Actors = new HashSet<Actor>();
        }
    }
}
