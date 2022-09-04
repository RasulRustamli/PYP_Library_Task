using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Models;

public class Order
{
    private int Id { get; set; }
    private static int _id=1;
    public double TotalPrice { get; set; }
    public DateTime Data { get; set; }=DateTime.Now;
    public List<Book> Books;
    public Order()
    {
        Id = _id++;
        Books = new List<Book>();
    }
}
