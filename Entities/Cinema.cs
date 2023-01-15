using Core;


namespace Entities
{
    public class Cinema : BaseEntity
    {
        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public ICollection<Movie> Movies { get; set; }

        public Cinema()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
