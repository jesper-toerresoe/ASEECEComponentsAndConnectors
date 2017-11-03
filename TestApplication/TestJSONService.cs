using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookServiceRequester.Model.JSON;
using BookServiceRequester.Util.JSON;

namespace TestApplication
{
    class TestJSONService
    {

        public void testBookService()
        {
            BookServiceUtilJSON bookservice = new BookServiceUtilJSON("bookserviceaseece.azurewebsites.net", "", "api");
            //Test Author metoder
            AuthorsList alist = bookservice.GetAuthors();
            Author a = new Author() { Id = 2 };
            a = bookservice.GetAuthor(a);
            Author ath = bookservice.GetAuthor(a);
            ath.Name = "Peter Petersen";
            ath = bookservice.PostAuthor(ath);
            ath.Name = ath.Name + "Nielsen";
            bookservice.PutAuthor(ath);//No return of data as the copi comes from Requester/Client
            ath = bookservice.DeleteAuthor(ath);

            //Test Book metoder
            Book abook = new Book() { Author = a, AuthorId = a.Id, Genre = "Vrøvl og Snak", Price = 45, Title = "Det dur bare", Year = 2016 };
            Book nbook = bookservice.PostBook(abook);

            BooksList bkl = bookservice.GetBooks();
            //System.Console.WriteLine("Bog der skal slette indtast ID:");
            //int i = Int32.Parse(System.Console.ReadLine());

            Book bk = new Book() { Id = nbook.Id };
            Book gbk = bookservice.GetBook(bk);
            gbk.Title = gbk.Title + " Extra Tekst";
            bookservice.PutBook(gbk);
            bookservice.DeleteBook(gbk);

        }

    }

}
