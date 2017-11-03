using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookServiceRequester.Model.XML;
using BookServiceRequester.Util.XML;

namespace TestApplication
{
    class TestXMLService
    {
        public void testBookService()
        {
            BookServiceUtilXML bookservice = new BookServiceUtilXML("bookserviceaseece.azurewebsites.net", "", "api");
            //Test Author metoder
            ArrayOfAuthor  alist = bookservice.GetAuthors();
            Author a = new Author() { Id = 202 };
            a = bookservice.GetAuthor(a);
            Author ath = bookservice.GetAuthor(a);
            ath.Name = "Peter Petersen";
            ath = bookservice.PostAuthor(ath);
            ath.Name = ath.Name + "Nielsen";
            bookservice.PutAuthor(ath);//No return of data as the copi comes from Requester/Client
            ath = bookservice.DeleteAuthor(ath);
            BookAuthor ba = new BookAuthor() { Id = a.Id, Name = a.Name };
            //Test Book metoder
            Book abook = new Book() { Author = ba, AuthorId = a.Id, Genre = "Vrøvl og Snak", Price = 45, Title = "Det dur bare", Year = 2016 };
            Book nbook = bookservice.PostBook(abook);

            ArrayOfBook bkl = bookservice.GetBooks();

            Book bk = new Book() { Id = nbook.Id };
            Book gbk = bookservice.GetBook(bk);
            gbk.Title = gbk.Title + " Extra Tekst";
            bookservice.PutBook(gbk);

            bookservice.DeleteBook(gbk);
        }
    }
}
