using Microsoft.AspNetCore.Mvc;
using RestApiLab5.Models;
using RestApiLab5.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApiLab5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //File controller -> API -> API Controller with read/write actions
    public class BooksController : ControllerBase
    {

        private IBooks _BookRepo;

         public BooksController(IBooks bookRepo)
        {
            _BookRepo = bookRepo; //new InMemBookRepo();
        }

        // GET: api/<BooksController>
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _BookRepo.GetBooks().ToList();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(Guid id)
        {
            var book = _BookRepo.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        // POST api/<BooksController>
        [HttpPost]
        public ActionResult CreateBook(CreateOrUpdateBookSchema book)
        {
            var myBook = new Book();

            myBook.Id = Guid.NewGuid();
            myBook.Title = book.Title;
            myBook.Price = book.Price;

            _BookRepo.CreateBook(myBook);
            return Ok();
        } 

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public ActionResult UpdateBook(Guid id, CreateOrUpdateBookSchema book)
        {
            var myBook = _BookRepo.GetBook(id);
            if(myBook == null)
            {
                return NotFound();
            }
            myBook.Title = book.Title;
            myBook.Price = book.Price;

            _BookRepo.UpdateBook(id, myBook);
            return Ok();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(Guid id)
        {
            var myBook = _BookRepo.GetBook(id);

            if(myBook == null)
            {
                return NotFound();
            }

            _BookRepo.DeleteBook(id);
            return Ok();
        }
    }
}
