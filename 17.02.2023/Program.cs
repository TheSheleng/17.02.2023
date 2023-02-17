using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Liblrary test = new Liblrary();
            test.Books.Add(new Book("1asd", "5asd", "asd"));
            test.Books.Add(new Book("2asd", "4asd", "asd"));
            test.Books.Add(new Book("5asd", "1asd", "asd"));
            test.Books.Add(new Book("4asd", "2asd", "asd"));
            test.Books.Add(new Book("3asd", "3asd", "asd"));
            test.Books.Sort(new Book.SortByAuthor());
            foreach (Book book in test) Console.WriteLine(book.Name);
            
            Console.ReadKey();
        }
    }
}
