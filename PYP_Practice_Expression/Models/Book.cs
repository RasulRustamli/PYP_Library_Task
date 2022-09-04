using PYP_Practice_Expression.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Models
{
    public class Book
    {
        private int codeId=100;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public Book(string name,string authorname,int pageCount,double price)
        {
            codeId++;
            Name = name;
            AuthorName = authorname;
            PageCount = pageCount;
            Price = price;
            Code = name.CodeGenerateBook() + codeId;
        }

        
    }
}
