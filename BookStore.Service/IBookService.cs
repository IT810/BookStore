using BookStore.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetGadgets();
        IEnumerable<Book> GetCategoryGadgets(string categoryName, string gadgetName = null);
        Book GetGadget(int id);
        void CreateGadget(Book gadget);
        void SaveGadget();
    }
}
