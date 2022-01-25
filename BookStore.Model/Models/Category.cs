using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Book> Books { get; set; }

        public Category()
        {
            DateCreated = DateTime.Now;
        }
    }
}
