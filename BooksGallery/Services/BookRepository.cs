using BooksGallery.Models;
using System.Collections.Generic;

namespace BooksGallery.Services
{
    public class BookRepository : IBookRepository
    {
        public List<Book> Books { get; set; }
        public BookRepository()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "The Big Red Book of Beginner Books",
                    Author = "Various Authors",
                    Description = "A collection of easy books for a child learning to read",
                    PhotoName = "brbbb1.jpg",
                    PhotoPath = "/images/brbbb1.jpg"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Captain Underpants and the Attack of the Talking Toliets",
                    Author = "Dav Pilkey",
                    Description = "Two kids turned their elementary school principal into a real-life version of their fictional comic book hero. This time to stop evil attacking toliets ",
                    PhotoName = "cpt-underpants1.jpg",
                    PhotoPath = "/images/cpt-underpants1.jpg"
                },
                new Book()
                {
                    Id = 3,
                    Title = "The One and Only Sparkella",
                    Author = "Channing Tatum",
                    Description = "An Ode to Self-Esteem and the love between Father and Daughter",
                    PhotoName = "sparkella1.jpg",
                    PhotoPath = "/images/sparkella1.jpg"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Treasury of Stories",
                    Author = "Beatrix Potter",
                    Description = "A massive collection of tall tales of forest critters with beautiful illustrations",
                    PhotoName = "treasury-stories1.jpg",
                    PhotoPath = "/images/treasury-stories1.jpg"
                },
            };
        }
        public void AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Book GetBook(int? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return Books.Find(x => x.Id == id);
            }
            
        }

        public List<Book> ReadAll()
        {
            return Books;
        }

        public void UpdateBook(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}
