﻿using cs_mvcs_and_apis_sprint.Models;
namespace cs_mvcs_and_apis_sprint.Services;

public class BookService
{
    private readonly BookModel _bookModel;

    public BookService(BookModel bookModel)
    {
        _bookModel = bookModel;
    }

    public List<Book> GetBooks()
    {
        return _bookModel.FetchBooks();
    }

    public Book? GetBookById(int id)
    {
        return _bookModel.FetchBookById(id);
    }

    public void PostBook(Book book)
    {
        _bookModel.PostBook(book);
    }

    public bool DeleteBook(int Id)
    {
        return _bookModel.DeleteBook(Id);
    }

    public bool TryGetBooksByAuthorId(int authorId, out List<Book> books)
    {
        if (_bookModel.TryFetchBooksByAuthorId(authorId, out books)) return true;
        return false;
    }
}
