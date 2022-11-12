﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DemoShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DemoShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        } 

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}