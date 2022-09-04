using PYP_Practice_Expression.Models;
using PYP_Practice_Expression.Repositories;
using PYP_Practice_Expression.Services;

Book book = new Book("Proggraming", "Rasul", 23,123.2);
Book book1 = new Book("Pro", "Rasul", 23,23.4);
Book book12 = new Book("Nulable", "Rasul", 23,123.4);
Book book13 = new Book("Delete", "Rasul", 23,213.2);
Book book14 = new Book("Proggr1", "Rasul", 23,54.2);
Library libary=new Library("BTK");

LibraryRepository libraryRepository = new LibraryRepository(libary);
LibraryService libraryService = new LibraryService(libraryRepository);
OrderService orderService = new OrderService(libraryRepository);


libraryService.AddBook(book);
libraryService.AddBook(book12);
libraryService.AddBook(book13);
libraryService.AddBook(book14);
libraryService.AddBook(book1);

var order = orderService.Sale(x => x.Name.Contains("Pro"));
Console.WriteLine(order.TotalPrice);







