using Microsoft.AspNetCore.Mvc;
using cs_mvcs_and_apis_sprint.Services;

namespace cs_mvcs_and_apis_sprint.Controllers
{
    [Route("/")]
    [ApiController]
    public class AuthorController :Controller
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
    }
}
