using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class DireccionRepository : Repository<Direccion>, IDireccionRepository
    {
      //  private readonly VetStoreContext _Context;

        public DireccionRepository(VetStoreContext context) : base(context)
        {
           
        }
       
    }
}
