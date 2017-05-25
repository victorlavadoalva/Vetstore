﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class MedioPagoRepository : Repository<MedioPago>, IMedioPagoRepository
    {
      //  private readonly VetStoreContext _Context;

        public MedioPagoRepository(VetStoreContext context) : base(context)
        {
           
        }
       
        
    }
}
