﻿using BookStore.Model.Models;
using Store.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    class BookRepository : RepositoryBase<Book>, IGadgetRepository
    {
        public BookRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IGadgetRepository : IRepository<Book>
    {

    }
}