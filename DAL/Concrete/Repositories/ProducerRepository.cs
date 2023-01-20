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
    public class ProducerRepository : EFRepositoryBase<Producer, AppDbContext>, IProducerDAL
    {
        public ProducerRepository(AppDbContext db) : base(db)
        {
        }
    }
}
