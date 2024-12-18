using cs_mvcs_and_apis_sprint.Models;

namespace cs_mvcs_and_apis_sprint.Services;

public class AuthorService
{
    private readonly AuthorModel _authorModel;
    public AuthorService(AuthorModel authorModel)
    {
        _authorModel = authorModel;
    }

    public List<Author> GetAllAuthors()
    {
        return _authorModel.FetchAuthors();
    }

    public Author? GetAuthorById(int id)
    {
        return _authorModel.FetchAuthorById(id);
    }
}
