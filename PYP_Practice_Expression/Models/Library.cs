using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Library(string Name)
        {
            this.Name = Name;
            Books = new List<Book>();
        }

  
    }
}
