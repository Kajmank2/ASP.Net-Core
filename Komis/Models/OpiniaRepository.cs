﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{


    public class OpiniaRepository : IOpiniaRepozitory
    {
        private readonly AppDbContext _appDbContext;
        public OpiniaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void DodajOpinie(Opinia opinia)
        {
            _appDbContext.Opinie.Add(opinia);
            _appDbContext.SaveChanges();
        }
      
    }
}
