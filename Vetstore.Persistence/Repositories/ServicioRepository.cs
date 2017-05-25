using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        //private readonly VetStoreContext _Context;

        public ServicioRepository(VetStoreContext context) : base(context)
        {
        
        }
        
    }
}
