using BookServiceRequester.Model.JSON;

namespace BookServiceRequester.Util.JSON
{
    interface IBookServiceUtilJSON
    {
        Author DeleteAuthor(Author author);
        Book DeleteBook(Book book);
        Author GetAuthor(Author author);
        AuthorsList GetAuthors();
        Book GetBook(Book book);
        BooksList GetBooks();
        Author PostAuthor(Author author);
        Book PostBook(Book book);
        Author PutAuthor(Author author);
        Book PutBook(Book book);
    }
}