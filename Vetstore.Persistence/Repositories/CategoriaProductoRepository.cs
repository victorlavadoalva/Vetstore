using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class CategoriaProductoRepository : Repository<CategoriaProducto>, ICategoriaProductoRepository
    {
       // private readonly VetStoreContext _Context;

        public CategoriaProductoRepository(VetStoreContext context) : base(context)
        {
          
        }

      
    }
}
