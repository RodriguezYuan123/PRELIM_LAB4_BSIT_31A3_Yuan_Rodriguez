using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book
                {
                    Title = "LOTR",
                    Author = new Author { Name = "J.R.R. Tolkien" },
                    Genre = "Kids",
                    IsAvailable = true
                },
                new Book
                {
                    Title = "Harry Puto",
                    Author = new Author { Name = "H.K. Rowling" },
                    Genre = "Scifi",
                    IsAvailable = true
                },
                new Book
                {
                    Title = "DDS: Anthology",
                    Author = new Author { Name = "J.R.R. Abante" },
                    Genre = "Kids",
                    IsAvailable = true
                },
                new Book
                {
                    Title = "Iron Man",
                    Author = new Author { Name = "J.R.R. Mustafa" },
                    Genre = "Horror",
                    IsAvailable = true
                },
                new Book
                {
                    Title = "Marvelous",
                    Author = new Author { Name = "Hulk Hogan" },
                    Genre = "Educational",
                    IsAvailable = true
                },
                new Book
                {
                    Title = "Prince of Darkness",
                    Author = new Author { Name = "Ozzy Osbourne" },
                    Genre = "Kids",
                    IsAvailable = true
                }
            };

            return View(books);
        }
        
        public IActionResult User()
        {
            var users = new List<User>
            {
                new User
                {
                    Username = "Rodriguez, Yuan Jasper",
                    BorrowedBooks = new List<BorrowRecord>
                    {
                        new BorrowRecord
                        {
                            Book = new Book
                            {
                                Title = "Testing",
                                Author = new Author { Name = "Aesop" },
                                Genre = "Horror"
                            },
                            DateBorrowed = new DateTime(2025, 7, 29)
                        },
                        new BorrowRecord
                        {
                            Book = new Book
                            {
                                Title = "Art of War",
                                Author = new Author { Name = "Aesop" },
                                Genre = "Kids"
                            },
                            DateBorrowed = new DateTime(2025, 7, 29)
                        },
                        new BorrowRecord
                        {
                            Book = new Book
                            {
                                Title = "Recipe Book",
                                Author = new Author { Name = "Aesop" },
                                Genre = "Horror"
                            },
                            DateBorrowed = new DateTime(2025, 7, 29),
                            DateReturned = new DateTime(2025, 7, 31)
                        }
                    }
                },
                new User
                {
                    Username = "Atog, Sean Yzer",
                    BorrowedBooks = new List<BorrowRecord>
                    {
                        new BorrowRecord
                        {
                            Book = new Book
                            {
                                Title = "Legend of Aang",
                                Author = new Author { Name = "Aesop" },
                                Genre = "Horror"
                            },
                            DateBorrowed = new DateTime(2025, 7, 29)
                        },
                        new BorrowRecord
                        {
                            Book = new Book
                            {
                                Title = "Art of War",
                                Author = new Author { Name = "Aesop" },
                                Genre = "Kids"
                            },
                            DateBorrowed = new DateTime(2025, 8, 2)
                        },
                        new BorrowRecord
                        {
                            Book = new Book
                            {
                                Title = "Testing of Mana",
                                Author = new Author { Name = "Aesop" },
                                Genre = "Fiction"
                            },
                            DateBorrowed = new DateTime(2025, 6, 19)
                        }
                    }
                }
            };

            return View(users);
        }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class BorrowRecord
    {
        public Book Book { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime? DateReturned { get; set; }
    }

    public class User
    {
        public string Username { get; set; }
        public List<BorrowRecord> BorrowedBooks { get; set; } = new();
    }
}
