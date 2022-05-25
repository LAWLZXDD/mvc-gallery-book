using BooksGallery.Models;
using System.Collections.Generic;

namespace BooksGallery.Services
{
    public interface IBookRepository
    {
        List<Book> Books { get; set; }
        List<Book> ReadAll();
        Book GetBook(int? id);

        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int? id);

    }
}
