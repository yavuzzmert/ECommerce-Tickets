using DAL.Abstract;
using DAL.Base.EntityFramework;
using DAL.Concrete.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.Repositories
{
    public class ActorRepository : EFRepositoryBase<Actor, AppDbContext>, IActorDAL
    {
        public ActorRepository(AppDbContext db) : base(db)
        {

        }
    }
}
