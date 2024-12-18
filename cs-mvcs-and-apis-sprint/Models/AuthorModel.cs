using System.Text.Json;
namespace cs_mvcs_and_apis_sprint.Models;

public class AuthorModel
{
    public List<Author> FetchAuthors()
    {
        //Load data from json or the db
        List<Author> authors = ReadAuthorData();
        return authors;
    }

    public Author? FetchAuthorById(int id)
    {
        var authors = ReadAuthorData();
        return authors.Where(a => a.Id == id).FirstOrDefault();
    }

    private List<Author> ReadAuthorData()
    {
        return JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources/Authors.json"))!;
    }
}
