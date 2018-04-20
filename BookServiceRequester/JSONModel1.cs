using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookServiceRequesterNew
{
    /*
     * [
  {
    "Id": 6,
    "Title": "Pride and Prejudice",
    "Year": 1813,
    "Price": 9.99,
    "Genre": "Comedy of manners",
    "AuthorId": 5,
    "Author": {
      "Id": 5,
      "Name": "Jane Austen"
    }
  },
  {
    "Id": 7,
    "Title": "Northanger Abbey",
    "Year": 1817,
    "Price": 12.95,
    "Genre": "Gothic parody",
    "AuthorId": 5,
    "Author": {
      "Id": 5,
      "Name": "Jane Austen"
    }
  },
  {
    "Id": 8,
    "Title": "David Copperfield",
    "Year": 1850,
    "Price": 15,
    "Genre": "Bildungsroman",
    "AuthorId": 6,
    "Author": {
      "Id": 6,
      "Name": "Charles Dickens"
    }
  },
  {
    "Id": 9,
    "Title": "Don Quixote",
    "Year": 1617,
    "Price": 8.95,
    "Genre": "Picaresque",
    "AuthorId": 7,
    "Author": {
      "Id": 7,
      "Name": "Miguel de Cervantes"
    }
  },
  {
    "Id": 10,
    "Title": "BookService på godt og ondt",
    "Year": 1025,
    "Price": 18.95,
    "Genre": "Survival",
    "AuthorId": 8,
    "Author": {
      "Id": 8,
      "Name": "Jesper R Tørresø"
    }
  },
  {
    "Id": 13,
    "Title": "Hej",
    "Year": 1958,
    "Price": 23.45,
    "Genre": "Sludjer og vrøwl",
    "AuthorId": 5,
    "Author": {
      "Id": 5,
      "Name": "Jane Austen"
    }
  }
]
     * */

    public class BookListe
    {
        public List<Book2> Property1 { get; set; }
    }

    public class Book2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    //public class Author
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}


    public class Bookliste2
    {
        public List<Book> Books { get; set; }
    }

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
        public string Editor { get; set; }
    }

}
