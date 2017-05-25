using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class LocalRepository : Repository<Local>, ILocalRepository
    {
       // private readonly VetStoreContext _Context;

        public LocalRepository(VetStoreContext context) : base(context)
        {
          
        }
       
    }
}
