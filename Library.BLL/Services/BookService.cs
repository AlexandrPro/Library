using Library.DAL.EF;
using Library.DAL.Repository;
using Library.Shared.Entities;
using Library.Shared.ViewModels.Book;
using System;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class BookService 
    {
        LibraryContext db;
        BookRepository bookRepository;

        public BookService()
        {
            db = new LibraryContext();
            bookRepository = new BookRepository(db);
        }

        public void Create(CreateBookViewModel item)
        {
            //TODO: validation
            Book book = new Book //TODO: automaper
            {
                Id = item.Id,
                Author = item.Author,
                Name = item.Name,
                YearOfPublishing = item.YearOfPublishing
            };
            bookRepository.Create(book);
        }

        public IndexBookViewModel GetAll()
        {
            IEnumerable<Book> books = bookRepository.GetAll();
            IndexBookViewModel bookVM = new IndexBookViewModel();
            bookVM.books = new List<BookViewModel>();
            foreach (Book item in books) //TODO: automaper
            {
                bookVM.books.Add(new BookViewModel
                {
                    Id = item.Id,
                    Author = item.Author,
                    Name = item.Name,
                    YearOfPublishing = item.YearOfPublishing
                });
            }

            return bookVM;
        }
    }
}
