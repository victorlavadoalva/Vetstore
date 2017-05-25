using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
      //  private readonly VetStoreContext _Context;

        public ProductoRepository(VetStoreContext context) : base(context)
        {
            
        }
       
    }
}
