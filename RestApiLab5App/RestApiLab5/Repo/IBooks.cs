using RestApiLab5.Models;

namespace RestApiLab5.Repo
{

    //Need to create Folder Repo and then Add -> New Item -> InterFace
    public interface IBooks
    {
        public IEnumerable<Book> GetBooks();
        public Book GetBook(Guid id);
        public void CreateBook(Book book);

        public void UpdateBook(Guid id, Book book);

        public void DeleteBook(Guid id);
    }
}
