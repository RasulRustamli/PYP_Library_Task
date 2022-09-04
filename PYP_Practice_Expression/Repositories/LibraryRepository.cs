using PYP_Practice_Expression.Abstractions.Repositories;
using PYP_Practice_Expression.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Repositories
{
    public class LibraryRepository : ILibraryRepository<Book>
    {
        //ozum context yaratmadim
        private readonly Library _library;
        public LibraryRepository(Library library)
        {
            _library = library;
        }

        public void Add(Book book)
        {
            _library.Books.Add(book);
        }

        public List<Book> FindAll(Predicate<Book> predicate)
        {
            return _library.Books.FindAll(predicate);
        }

        public Book Get(Predicate<Book> predicate)
        {
             return _library.Books.Find(predicate);
        }

        public List<Book> GetAll()
        {
            return _library.Books;
        }

        public int RemoveAll(Predicate<Book> predicate)
        {
            return _library.Books.RemoveAll(predicate);
        }
    }
}
