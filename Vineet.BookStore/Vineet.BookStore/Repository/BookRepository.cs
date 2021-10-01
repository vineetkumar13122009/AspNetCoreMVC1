using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vineet.BookStore.Models;

namespace Vineet.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Vineet"},
                new BookModel(){Id=2,Title="ASP.net",Author="Sankesh"},
                new BookModel(){Id=3,Title="Database",Author="Rupesh"},
                new BookModel(){Id=4,Title="Hello",Author="Mukul"},
                new BookModel(){Id=5,Title="Electronics",Author="Nitish"},
                new BookModel(){Id=6,Title="Core",Author="Vineet"},
                new BookModel(){Id=7,Title="PHP",Author="Mukul"},
                new BookModel(){Id=8,Title="Python",Author="Sankesh"},
                new BookModel(){Id=9,Title="Angular",Author="Vineet"},
            };
        }
    }
}
