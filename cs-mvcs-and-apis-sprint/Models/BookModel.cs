using System.Text.Json;
namespace cs_mvcs_and_apis_sprint.Models;

public class BookModel
{
    public List<Book> GetBooks()
    {
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText("Resources/Books.json"))!;
        return books;
    }
}
