using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetstore.Entities.IRepositories
{
    public interface IAtencionRepository : IRepository<Atencion>
    {
        Atencion Get(int? id);
        object Add(Func<object, object> p);
    }
}
