﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.ViewModels
{
    public class BookViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryID { get; set; }
    }
}