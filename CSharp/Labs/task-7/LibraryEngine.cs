using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList
        ,BookFunctionsDelegate<Book, string> fPtr)

        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
