using Vetstore.Entities;
using Vetstore.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Vetstore.Persistence.Repositories
{
    public class AtencionRepository : Repository<Atencion>, IAtencionRepository
    {
     
        public AtencionRepository(VetStoreContext context):base(context)
        {
            
        }

        public object Add(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
