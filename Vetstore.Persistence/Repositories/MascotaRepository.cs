﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities;
using Vetstore.Entities.IRepositories;

namespace Vetstore.Persistence.Repositories
{
    public class MascotaRepository : Repository<Mascota>, IMascotaRepository
    {
        //private readonly VetStoreContext _Context;

        public MascotaRepository(VetStoreContext context) : base(context)
        {
            
        }
       
    }
}
