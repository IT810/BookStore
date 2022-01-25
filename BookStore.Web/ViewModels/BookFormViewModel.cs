using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.ViewModels
{
    public class BookFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Category { get; set; }
    }
}