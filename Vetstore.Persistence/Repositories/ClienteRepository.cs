using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        //private readonly VetStoreContext _Context;

        public ClienteRepository(VetStoreContext context) : base(context)
        {
         
        }
       
    }
}
