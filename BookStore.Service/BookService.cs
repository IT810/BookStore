using BookStore.Data.Repositories;
using BookStore.Model.Models;
using Store.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public BookService(IBookRepository bookRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.bookRepository = bookRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Book> GetGadgets()
        {
            var books = bookRepository.GetAll();
            return books;
        }

        public IEnumerable<Book> GetCategoryGadgets(string categoryName, string gadgetName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.Books.Where(g => g.Name.ToLower().Contains(gadgetName.ToLower().Trim()));
        }

        public Book GetGadget(int id)
        {
            var gadget = bookRepository.GetById(id);
            return gadget;
        }

        public void CreateGadget(Book book)
        {
            bookRepository.Add(book);
        }

        public void SaveGadget()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
