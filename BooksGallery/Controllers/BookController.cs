using Microsoft.AspNetCore.Mvc;
using BooksGallery.Models;
using BooksGallery.Services;

namespace BooksGallery.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookData;
        public BookController(IBookRepository bookData)
        {
            _bookData = bookData;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Books = _bookData.ReadAll();
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            var bookDetail = _bookData.GetBook(id);
            if(bookDetail == null)
            {
                return NotFound();
            }
            return View(bookDetail);
        }
    }
}
