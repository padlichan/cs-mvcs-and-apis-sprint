using System.Text.Json;
namespace cs_mvcs_and_apis_sprint.Models;

public class BookModel
{
    public List<Book> FetchBooks()
    {
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText("Resources/Books.json"))!;
        return books;
    }

    public Book? FetchBookById(int id)
    {
        var books = FetchBooks();
        return books.Where(b => b.Id == id).FirstOrDefault();
    }

    public void PostBook(Book book)
    {
        var books = FetchBooks();
        book.Id = books.Last().Id + 1;  
        books.Add(book);
        WriteData(books);

    }

    public bool DeleteBook(int id)
    {
        var books = FetchBooks();
        Book? bookToDelete = books.Where(b => b.Id == id).FirstOrDefault();
        if (bookToDelete == null) return false;
        books.Remove(bookToDelete);
        WriteData(books);
        return true;
    }

    private void WriteData(List<Book> books)
    {
        File.WriteAllText("Resources/Books.json", JsonSerializer.Serialize(books));
    }
       
}
