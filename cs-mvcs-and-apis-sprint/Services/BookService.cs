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
        return _bookModel.GetBooks();
    }
}