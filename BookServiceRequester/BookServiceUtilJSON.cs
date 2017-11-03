using System;
using System.Collections.Generic;
using BookServiceRequester.Model.JSON;
using DALRESTfulUtil.HttpClientJson;

namespace BookServiceRequester.Util.JSON
{

    public class BookServiceUtilJSON : IBookServiceUtilJSON
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;


        public BookServiceUtilJSON(string hname, string portno, string serpath)
        {
            portnumber = portno;
            hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = "http://" + hname + ":" + portno + "/" + servicepath;
        }

        /*
        * Author metoder 
        */
        public AuthorsList GetAuthors()
        {
            AuthorsList al = new AuthorsList(); //AuthorsList er en Wrapper model klasse der indpakker en List<Author> liste
            APIGetJSON<List<Author>> authlist = new APIGetJSON<List<Author>>(fullservicepath + "Authors");
            al.Authors = authlist.data;
            return al;
        }

        public Author GetAuthor(Author author)
        {
            APIGetJSON<Author> auth = new APIGetJSON<Author>(fullservicepath + "Authors/"+author.Id);
            return auth.data;
        }

        public Author PostAuthor(Author author) //Opretter et nyt Author objekt på BookService Web API
        {
            APIPostJSON<Author> athpost = new APIPostJSON<Author>(this.hostname, this.servicepath + "Authors", author);
            return athpost.data;
        }

        public Author PutAuthor(Author author) //Opdater et Author objekt på BookService Web API
        {
            APIPutJSON<Author> athput = new APIPutJSON<Author>(this.hostname, this.servicepath + "Authors/" + author.Id, author);
            return athput.data;
        }
        public Author DeleteAuthor(Author author) //Sletter et  Author objekt på BookService Web API
        {
            APIDeleteJSON<Author> athdelete = new APIDeleteJSON<Author>(this.hostname, this.servicepath + "Authors/" + author.Id, author);
            return athdelete.data;
        }

        /*
         * Book metoder 
         */

        public BooksList GetBooks()
        {
            BooksList bl = new BooksList();//BooksList er en Wrapper model klasse der indpakker en List<Book> liste
            APIGetJSON<List<Book>> authlist = new APIGetJSON<List<Book>>(this.fullservicepath + "Books");
            bl.Books = authlist.data;
            return bl;
        }
        public Book GetBook(Book book)
        {
            APIGetJSON<Book> b = new APIGetJSON<Book>(this.fullservicepath + "Books/"+book.Id);
            return b.data;
        }

        public Book PostBook(Book book) //Opretter et nyt Book objekt på BookService Web API
        {
            APIPostJSON<Book> bookpost = new APIPostJSON<Book>(this.hostname, this.servicepath + "Books", book);
            return bookpost.data;
        }

        public Book PutBook(Book book) //Opdater et Book objekt på BookService Web API
        {
            APIPutJSON<Book> bookput = new APIPutJSON<Book>(this.hostname, this.servicepath + "Books/" + book.Id, book);
            return bookput.data;
        }
        public Book DeleteBook(Book book) //Sletter et  Book objekt på BookService Web API
        {
            APIDeleteJSON<Book> bookdelete = new APIDeleteJSON<Book>(this.hostname, this.servicepath + "Books/" + book.Id, book);
            return bookdelete.data;
        }
       
    }
}


