using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_first_task
{
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        public Book(string name , int pageCount)
        {
            if(pageCount > 10 && name.Length > 3)
            {
                Name = name;
                PageCount = pageCount;
            }
            else
            {
                Console.WriteLine("Duzgun daxil edilmeyib.");
            }
        }
    }
}
