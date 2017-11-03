using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookServiceRequester.Model.JSON
{
    
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    public class BooksList
    {
        public List<Book> Books { get; set; }
    }
    
    public class AuthorsList
    {
        public List<Author> Authors { get; set; }
    }

}
