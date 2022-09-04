using PYP_Practice_Expression.Abstractions.Services;
using PYP_Practice_Expression.Models;
using PYP_Practice_Expression.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Services
{
    public class OrderService : IOrderService
    {
        public LibraryRepository _libraryRepository;

        public OrderService(LibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public Order Sale(Predicate<Book> method)
        {
            List<Book> books = _libraryRepository.FindAll(method);
            if(books.Count == 0)
            {
                Console.WriteLine("Verilmis sertlerde kitab yoxdur");
                return null;
            }
            var price=books.Sum(b=>b.Price);
            if(price >200)
            {
                price = price - (price * 20 / 100);
            }
            else if(price>100)
            {
                price = price - (price * 10 / 100);
            }
            return new Order
            {
                Books = books,
                TotalPrice = price
            };
        }
    }
}
