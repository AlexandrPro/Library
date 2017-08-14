using Library.BLL.Interfaces;
using Library.BLL.ViewModels;
using Library.DAL.Interfaces;
using Library.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class BookService : IBookService
    {
        IUnitOfWork db { get; set; }

        public BookService(IUnitOfWork uow)
        {
            db = uow;
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
            db.Books.Create(book);
        }

        public IEnumerable<BookVM> GetAll()
        {
            IEnumerable<Book> books = db.Books.GetAll();
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
