using PYP_Practice_Expression.Abstraction.Services;
using PYP_Practice_Expression.Abstractions.Repositories;
using PYP_Practice_Expression.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Services;

public class LibraryService : ILibraryService<Book>
{
    private readonly ILibraryRepository<Book> libraryRepository;
    public LibraryService(ILibraryRepository<Book> libraryRepository)
    {
        this.libraryRepository = libraryRepository;

    }

    public void AddBook(Book value)
    {
        libraryRepository.Add(value);
    }

    public List<Book> FindAllBooks(Predicate<Book> predicate)
    {
        var Books = libraryRepository.FindAll(predicate);
        if (Books.Count == 0)
        {
            Console.WriteLine("We dont have book");
        }
        return Books;
    }





    public Book GetBook(Predicate<Book> predicate)
    {
        Book book = libraryRepository.Get(predicate);
        if (book == null)
        {
            Console.WriteLine("verilmis sertler daxilinde kitab yoxdur ");
        }
        return book;
    }

    public int RemoveAllBooks(Predicate<Book> predicate)
    {
        return libraryRepository.RemoveAll(predicate);
    }


}
