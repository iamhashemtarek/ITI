using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    public class BookFunctions
    {
        public static Func<Book, string> GetTitle = B => $"book-title: {B.Title}";
        public static string GetAuthors(Book B)
        {
            StringBuilder author = new StringBuilder();
            for (int i = 0; i < B.Authors.Length; i++)
            {
                author.Append($"author[i], ");
            }
            return author.ToString();
        }
        public static Func<Book, string> GetPrice = B => $"price: {B.Price}";
        public static BookFunctionsDelegate<Book, string> GetISBN = B => $"ISBN:{B.ISBN}";

    }
}
