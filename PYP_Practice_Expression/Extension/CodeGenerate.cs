using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Practice_Expression.Extension;

public static class CodeGenerate
{
    public static string CodeGenerateBook(this string value)
    {
        if(value.Contains(" "))
        {
            StringBuilder sb = new StringBuilder();
            string[] words=value.Split(' ');
            foreach(string word in words)
            {
                sb.Append(word.ToUpper()[0]);
            }
            return sb.ToString();
        }
        
         return value.Substring(0, 2).ToUpper();
        
    }
}
