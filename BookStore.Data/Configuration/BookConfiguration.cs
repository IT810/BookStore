using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using BookStore.Model.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Configuration
{
    class BookConfiguration: EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            ToTable("Books");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
            Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            Property(g => g.CategoryID).IsRequired();
        }
    }
}
