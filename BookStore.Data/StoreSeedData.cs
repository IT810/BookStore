using BookStore.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    class StoreSeedData : DropCreateDatabaseIfModelChanges<StoreDBContext>
    {
        protected override void Seed(StoreDBContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetGadgets().ForEach(g => context.Books.Add(g));

            context.Commit();
        }

        private static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category {
                    Name = "Computers & Technology"
                },
                new Category {
                    Name = "Comic Books & Graphic Novels"
                },
                new Category {
                    Name = "Business & Investing"
                }
            };
        }

        private static List<Book> GetGadgets()
        {
            return new List<Book>
            {
                new Book {
                    Name = "The C Programming Language",
                    Description = "The authors present the complete guide to ANSI standard C language programming. Written by the developers of C, this new version helps readers keep up with the finalized ANSI standard for C while showing how to take advantage of C's rich set of operators, economy of expression, improved control flow, and data structures. The 2/E has been completely rewritten with additional examples and problem sets to clarify the implementation of difficult language...",
                    CategoryID = 1,
                    Price = 29.99m,
                    Image = "book1"
                }, 
            };
        }
    }
}
