using DAL.Abstract;
using DAL.Base.EntityFramework;
using DAL.Concrete.Context;
using Entities;

namespace DAL.Concrete.Repositories
{
    public class CinemaRepository : EFRepositoryBase<Cinema, AppDbContext>, ICinemaDAL
    {
        public CinemaRepository(AppDbContext db) : base(db)
        {
        }
    }
}
