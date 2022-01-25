using AutoMapper;
using BookStore.Model.Models;
using BookStore.Service;
using BookStore.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IBookService bookService;

        public HomeController(ICategoryService categoryService, IBookService bookService)
        {
            this.categoryService = categoryService;
            this.bookService = bookService;
        }

        // GET: Home
        public ActionResult Index(string category = null)
        {
            IEnumerable<CategoryViewModel> viewModelGadgets;
            IEnumerable<Category> categories;

            categories = categoryService.GetCategories(category).ToList();

            viewModelGadgets = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(viewModelGadgets);
        }

        public ActionResult Filter(string category, string gadgetName)
        {
            IEnumerable<BookViewModel> bookViewModels;
            IEnumerable<Book> books;

            books = bookService.GetCategoryGadgets(category, gadgetName);

            bookViewModels = Mapper.Map<IEnumerable<Book>, IEnumerable<bookViewModels>>(books);

            return View(books);
        }

        [HttpPost]
        public ActionResult Create(BookFormViewModel newBook)
        {
            if (newBook != null && newBook.File != null)
            {
                var gadget = Mapper.Map<BookFormViewModel, Book>(newBook);
                bookService.CreateGadget(gadget);

                string gadgetPicture = System.IO.Path.GetFileName(newBook.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/"), gadgetPicture);
                newBook.File.SaveAs(path);

                bookService.SaveGadget();
            }

            var category = categoryService.GetCategory(newBook.Category);
            return RedirectToAction("Index", new { category = category.Name });
        }
    }
}