using BookStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        StoreDBContext dbContext;

        public StoreDBContext Init()
        {
            return dbContext ?? (dbContext = new StoreDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
