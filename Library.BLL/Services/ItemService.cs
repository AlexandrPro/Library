using Library.BLL.ViewModels;
using Library.DAL.EF;
using Library.DAL.Entities;
using Library.DAL.Repository;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class ItemService
    {
        LibraryContext db;
        EFRepository<Book> bookRepository;
        EFRepository<Magazine> magazineRepository;
        public ItemService()
        {
            db = new LibraryContext();
            magazineRepository = new EFRepository<Magazine>(db);
            bookRepository = new EFRepository<Book>(db);
        }

        public IndexItemViewModel GetAll()
        {
            IEnumerable<Book> books = bookRepository.GetAll();
            IEnumerable<Magazine> magazines = magazineRepository.GetAll();
            List<ItemViewModel> itemVMs = new List<ItemViewModel>();
            int i = 0;
            foreach (var item in books) 
            {
                ItemViewModel itemVM = new ItemViewModel
                {
                    Id = ++i,
                    Name = item.Name,
                    ItemType = "Book"
                };
                itemVMs.Add(itemVM);
            }
            foreach (var item in magazines)
            {
                ItemViewModel itemVM = new ItemViewModel
                {
                    Id = ++i,
                    Name = item.Name,
                    ItemType = "Magazine"
                };
                itemVMs.Add(itemVM);
            }

            return new IndexItemViewModel { items = itemVMs };
        }
    }
}
