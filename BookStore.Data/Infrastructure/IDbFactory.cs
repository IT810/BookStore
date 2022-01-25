using BookStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        StoreDBContext Init();
    }
}
