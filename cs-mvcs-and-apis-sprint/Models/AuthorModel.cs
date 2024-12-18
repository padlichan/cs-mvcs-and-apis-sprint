using System.Text.Json;
namespace cs_mvcs_and_apis_sprint.Models;

public class AuthorModel
{
    public List<Author> FetchAuthors()
    {
        //Load data from json or the db
        List<Author> authors = JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources/Authors.json"));
        return authors;
    }
}
