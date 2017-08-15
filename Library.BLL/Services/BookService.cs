using Library.BLL.ViewModels;
using Library.DAL.EF;
using Library.DAL.Entities;
using Library.DAL.Repository;
using System;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class BookService 
    {
        LibraryContext db;
        EFRepository<Book> bookRepository;

        public BookService()
        {
            db = new LibraryContext();
            bookRepository = new EFRepository<Book>(db);
        }

        public void Create(BookVM item)
        {
            //TODO: validation
            Book book = new Book //TODO: automaper
            {
                Id = item.Id,
                Author = item.Author,
                Name = item.Name,
                YearOfPublishing_ = item.YearOfPublishing_
            };
            bookRepository.Create(book);
        }

        public IEnumerable<BookVM> GetAll()
        {
            IEnumerable<Book> books = bookRepository.GetAll();
            List<BookVM> bookVMs = new List<BookVM>();
            foreach (Book item in books) //TODO: automaper
            {
                BookVM bookVM = new BookVM
                {
                    Id = item.Id,
                    Author = item.Author,
                    Name = item.Name,
                    YearOfPublishing_ = item.YearOfPublishing_
                };
                bookVMs.Add(bookVM);
            }

            return bookVMs;
        }
    }
}
