using System.Text.Json;
namespace cs_mvcs_and_apis_sprint.Models;

public class AuthorModel
{
    public List<Author> FetchAuthors()
    {
        //Load data from json or the db
        List<Author> authors = JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources/Authors.json"))!;
        return authors;
    }

    public Author? FetchAuthorById(int id)
    {
        var authors = FetchAuthors();
        return authors.Where(a => a.Id == id).FirstOrDefault();
    }

    public void PostAuthor(Author author)
    {
        var authors = FetchAuthors();
        author.Id = authors.Last().Id + 1;
        authors.Add(author);
        File.WriteAllText("Resources/Authors.json", JsonSerializer.Serialize(authors));
    }


    
}
