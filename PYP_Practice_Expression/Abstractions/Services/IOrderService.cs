using PYP_Practice_Expression.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Abstractions.Services;

public interface IOrderService
{
   public Order Sale(Predicate<Book> method);
   
}
