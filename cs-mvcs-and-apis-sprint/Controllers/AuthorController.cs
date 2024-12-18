using Microsoft.AspNetCore.Mvc;
using cs_mvcs_and_apis_sprint.Services;
using cs_mvcs_and_apis_sprint.Models;

namespace cs_mvcs_and_apis_sprint.Controllers;

[Route("/[controller]")]
[ApiController]
public class AuthorController : Controller
{
    private readonly AuthorService _authorService;

    public AuthorController(AuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public IActionResult GetAuthors()
    {
        var authors = _authorService.GetAllAuthors();
        return Ok(authors);
    }

    [HttpGet("{id}")]
    public IActionResult GetAuthorById(int id)
    {
        var author = _authorService.GetAuthorById(id);
        if(author == null)  return NotFound();
        return Ok(author);
    }
    [HttpPost]
    public IActionResult PostAuthor(Author author)
    {
        _authorService.PostAuthor(author);
        return Created(string.Empty, author);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAuthor(int id)
    {
        if(_authorService.DeleteAuthor(id)) return NoContent();
        return NotFound();

    }
}
