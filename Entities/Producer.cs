using Core;


namespace Entities
{
    public class Producer : BaseEntity
    {
        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Biography { get; set; }


        public ICollection<Movie> Movies { get; set; }

        public Producer()
        {
            Movies = new HashSet<Movie>();
        }
    }
}
