using cs_mvcs_and_apis_sprint.Services;
using Microsoft.AspNetCore.Mvc;

namespace cs_mvcs_and_apis_sprint.Controllers;

[Route("/[controller]")]
[ApiController]
public class BookController : Controller
{

    private readonly BookService _bookService;
    public BookController(BookService bookService)
    { 
        _bookService = bookService; 
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        var books = _bookService.GetBooks();
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetAuthorById(int id)
    {
        var author = _bookService.GetBookById(id);
        if (author == null) return NotFound();
        return Ok(author);
    }
}
