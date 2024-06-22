using BookAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace BookAPI.Controllers
{
    //https://localhost:7033/api/books:
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{Id = 1, Author = "Author One", Title = "Title One"},
            new Book{Id = 2, Author = "Author Two", Title = "Title Two"},
            new Book{Id = 3, Author = "Author Three", Title = "Title Three"}
        };

        //Get method
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks() 
        { 
            return Ok(_books); //If Ok return Books array
        }
    }
}
