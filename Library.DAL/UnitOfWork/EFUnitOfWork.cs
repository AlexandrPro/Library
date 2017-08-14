using System;
using Library.DAL.Entities;
using Library.DAL.EF;
using Library.DAL.Interfaces;
using Library.DAL.Repository;

namespace Library.DAL.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private LibraryContext db;
        private EFRepository<Book> bookRepository;

        public EFUnitOfWork()
        {
            db = new LibraryContext();
        }

        public IRepository<Book> Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new EFRepository<Book>(db);
                return bookRepository;
            }
        }
        /*
        public void Save()
        {
            //db.SaveChanges();
        }
        */
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
