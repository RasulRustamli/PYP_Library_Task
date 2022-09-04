using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Abstractions.Repositories;

public interface ILibraryRepository<T> where T : class
{
    public void Add(T book);
    public List<T> GetAll();
    public T Get(Predicate<T> method);
    public List<T> FindAll(Predicate<T> method);
    public int RemoveAll(Predicate<T> method);

}
