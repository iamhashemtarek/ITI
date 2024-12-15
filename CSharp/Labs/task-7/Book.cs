using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
        decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            StringBuilder author = new StringBuilder();
            for (int i = 0; i < Authors.Length; i++)
            {
                author.Append($"{author[i]}, ");
            }

            return $"ISBN: {ISBN}, Title: {Title}, Author: {Authors}, Publication-Date: {PublicationDate}, Price: {Price}";


        }
    }

   
}
