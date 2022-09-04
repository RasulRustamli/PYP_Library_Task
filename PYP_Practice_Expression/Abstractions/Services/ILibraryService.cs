using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Abstraction.Services;

public interface ILibraryService<T> where T : class
{
    public void AddBook(T book);
    public T GetBook(Predicate<T> predicate);
    public List<T> FindAllBooks(Predicate<T> predicate);
    public int RemoveAllBooks(Predicate<T> predicate);
}
