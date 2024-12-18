using cs_mvcs_and_apis_sprint.Services;
using Microsoft.AspNetCore.Mvc;

namespace cs_mvcs_and_apis_sprint.Controllers;

public class BookController : Controller
{

    private readonly BookService _bookService;
    public BookController(BookService bookService)
    { 
        _bookService = bookService; 
    }
    [Route("/[controller]")]
    public IActionResult GetBooks()
    {
        var books = _bookService.GetBooks();
        return Ok(books);
    }

}
