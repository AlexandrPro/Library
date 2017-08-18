using Library.DAL.EF;
using Library.DAL.Repository;
using Library.Shared.Entities;
using Library.Shared.ViewModels.Item;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class ItemService
    {
        LibraryContext db;
        BookRepository bookRepository;
        MagazineRepository magazineRepository;
        BrochureRepository brochureRepository;
        public ItemService()
        {
            db = new LibraryContext();
            magazineRepository = new MagazineRepository(db);
            bookRepository = new BookRepository(db);
            brochureRepository = new BrochureRepository(db);
        }

        public IndexItemViewModel GetAll()
        {
            IEnumerable<Book> books = bookRepository.GetAll();
            IEnumerable<Magazine> magazines = magazineRepository.GetAll();
            IEnumerable<Brochure> brochures = brochureRepository.GetAll();
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
            foreach (var item in brochures)
            {
                ItemViewModel itemVM = new ItemViewModel
                {
                    Id = ++i,
                    Name = item.Name,
                    ItemType = "Brochure"
                };
                itemVMs.Add(itemVM);
            }


            return new IndexItemViewModel { items = itemVMs };
        }
    }
}
