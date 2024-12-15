namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("b-ISBN", "b-Title", ["author-1", "author-2"], new DateTime(2023, 1, 1), 200);
            //Console.WriteLine( myBook.ToString());
            BookFunctionsDelegate<Book, string> d = delegate (Book book)
            {
                return $"price: {book.Price}";
            };

            BookFunctionsDelegate<Book, string> d1 =  book => $"price: {book.Price}";

        }
    }
}
