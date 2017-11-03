using System;
using System.Collections.Generic;
using BookServiceRequester.Model.XML;
using DALRESTfulUtil.HttpClientXML;

namespace BookServiceRequester.Util.XML
{

    public class BookServiceUtilXML
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;


        public BookServiceUtilXML(string hname, string portno, string serpath)
        {
            portnumber = portno;
            hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = "http://" + hname + ":" + portno + "/" + servicepath;
        }

        public ArrayOfAuthor GetAuthors()
        {
            APIGetXML<ArrayOfAuthor> authlist = new APIGetXML<ArrayOfAuthor>(fullservicepath + "Authors");
            return authlist.data;
        }

        public Author GetAuthor(Author auth)
        {
            APIGetXML<Author> gauth = new APIGetXML<Author>(fullservicepath + "Authors/"+auth.Id);
            return gauth.data;
        }

        public Author PostAuthor(Author auth)
        {
            APIPostXML<Author> athput = new APIPostXML<Author>(hostname, servicepath + "Authors", auth);
            return athput.data;
        }

        public Author PutAuthor(Author auth)
        {
            APIPutXML<Author> athput = new APIPutXML<Author>(hostname, servicepath + "Authors/" + auth.Id, auth);
            return athput.data;
        }

        /*
         * Altenativer til forrige PutAuthor og PostAuthor, metoder Bruger ArrayOfAuthorAuthor klassen        
        */
        public ArrayOfAuthorAuthor AltPutAuthor(ArrayOfAuthorAuthor author) //Opdater et Author objekt på BookService Web API
        {
            APIPutXML<ArrayOfAuthorAuthor> athput = new APIPutXML<ArrayOfAuthorAuthor>(hostname, servicepath + "Authors/" + author.Id, author);
            return athput.data;
        }
        
        public ArrayOfAuthorAuthor AltPostAuthor(ArrayOfAuthorAuthor author) //Opretter et Author objekt på BookService Web API
        {
            APIPostXML<ArrayOfAuthorAuthor> athput = new APIPostXML<ArrayOfAuthorAuthor>(hostname, servicepath + "Authors", author);
            return athput.data;
        }

        public Author DeleteAuthor(Author author)
        {
            APIDeleteXML<Author> athdelete = new APIDeleteXML<Author>(hostname, servicepath + "Authors/" + author.Id, author);
            return athdelete.data;
        }
                
        public ArrayOfAuthorAuthor AltDeleteAuthor(ArrayOfAuthorAuthor author) //Sletter et  Author objekt på BookService Web API
        {
            APIDeleteXML<ArrayOfAuthorAuthor> athdelete = new APIDeleteXML<ArrayOfAuthorAuthor>(hostname,servicepath + "Authors/" + author.Id, author);
            return athdelete.data;
        }

        /* Book metoder*/

        public Book GetBook(Book book)
        {
            APIGetXML<Book> getbook = new APIGetXML<Book>(fullservicepath + "Books/" + book.Id);
            return getbook.data;
        }

        public ArrayOfBook GetBooks()
        {
            APIGetXML<ArrayOfBook> booklist = new APIGetXML<ArrayOfBook>(fullservicepath + "Books");
            return booklist.data;
        }

        public Book DeleteBook(Book bk)
        {
            APIDeleteXML<Book> bookdelete = new APIDeleteXML<Book>(hostname, servicepath + "Books/" + bk.Id, bk);
            return bookdelete.data;
        }

        public Book PostBook(Book bl)
        {
            APIPostXML<Book> bookput = new APIPostXML<Book>(hostname, servicepath + "Books", bl);
            return bookput.data;
        }

        public Book PutBook(Book bk)
        {
            APIPutXML<Book> bookput = new APIPutXML<Book>(hostname, servicepath + "Books/" + bk.Id, bk);
            return bookput.data;
        }

    }
}


