using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._4_BookDll
{
    public class Book
    {
        
            public string ISBN { get; set; }
            public string BookName { get; set; }
            public string AuthorName { get; set; }
            public string Genre { get; set; }
            public int Year { get; set; }

    }
    public class BookRepo
    {
        private List<Book> booklist;
        public BookRepo()
        {
            booklist = new List<Book>() {new Book() { ISBN = "9781419741852", BookName = "Diary of A Wimpy Kid", AuthorName = "Jeff Kinney", Genre = "Young Adult Fiction", Year = 2007 }, };
        }
        public List<Book> GetBooks()
        {
            
            return booklist;
        }

        public void AddBook (Book newbook)
        {
            booklist.Add(newbook);
        }
        public void DeleteBook (int id)
        {
            booklist.RemoveAt(id);
        }

    }
}
