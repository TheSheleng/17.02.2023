using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2023
{
    internal class Book : IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Book(string name, string author, string genre)
        {
            Name = name;
            Author = author;
            Genre = genre;
        }
        public int CompareTo(object obj)
        {
            if (obj is Book book) return Name.CompareTo(book.Name);
            else throw new ArgumentException("Некорректное значение параметра");
        }
        public class SortByName : IComparer<Book>
        { 
            public int Compare(Book x, Book y)
            {
                if (x is null || y is null) throw new ArgumentException("Некорректное значение параметра");
                return x.Name.CompareTo(y.Name);
            }
        }
        public class SortByAuthor : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                if (x is null || y is null) throw new ArgumentException("Некорректное значение параметра");
                return x.Author.CompareTo(y.Author);
            }
        }
        class SortByGenre : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                if (x is null || y is null) throw new ArgumentException("Некорректное значение параметра");
                return x.Genre.CompareTo(y.Genre);
            }
        }
        public object Clone()
        {
            return new Book(Name, Author, Genre);
        }
    }
}
