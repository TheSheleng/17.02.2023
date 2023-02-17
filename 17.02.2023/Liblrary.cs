using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2023
{
    internal class Liblrary : IEnumerable
    {
        public List<Book> Books = new List<Book>();
        public IEnumerator GetEnumerator()
        { 
            foreach (var item in Books) yield return item;
        }
    }
}