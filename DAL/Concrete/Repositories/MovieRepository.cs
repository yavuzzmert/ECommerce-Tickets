using DAL.Abstract;
using DAL.Base.EntityFramework;
using DAL.Concrete.Context;
using Entities;

namespace DAL.Concrete.Repositories
{
    public class MovieRepository : EFRepositoryBase<Movie, AppDbContext>, IMovieDAL
    {
        public MovieRepository(AppDbContext db) : base(db)
        {
        }
    }
}
