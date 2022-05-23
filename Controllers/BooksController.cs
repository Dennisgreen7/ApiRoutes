using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(5)}")]
        public string GetBooks(int id)
        {
            return "Book Id (INT - min 5): "+id;
        }
        [Route("{id:regex(book(boom|zoom))}")]
        public string GetBooksRegex(string id)
        {
            return "Book Id (Regex): " + id;
        }
    }
}
