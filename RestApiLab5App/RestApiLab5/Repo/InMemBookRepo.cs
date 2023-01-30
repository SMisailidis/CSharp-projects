using System.Reflection;
using RestApiLab5.Models;

namespace RestApiLab5.Repo
{
    public class InMemBookRepo : IBooks
    {
        private List<Book> _books;

        public InMemBookRepo()
        {
            _books = new() { new Book { Id = Guid.NewGuid(), Title = "Book 0", Price = 10 } };
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public void CreateBook(Book book)
        {
            _books.Add(book);
        }

        public void DeleteBook(Guid id)
        {
            var bookIndex = _books.FindIndex(x => x.Id == id);
            
            if(bookIndex > -1)
            {
                _books.RemoveAt(bookIndex);
            }
        }

        public Book GetBook(Guid id)
        {
            var book = _books.Where(x => x.Id == id).SingleOrDefault();
            return book;
        }

        public void UpdateBook(Guid id, Book book)
        {
            var bookIndex = _books.FindIndex(x => x.Id == id);
            if(bookIndex > -1)
            {
                _books[bookIndex] = book;
            }
        }
    }
}
