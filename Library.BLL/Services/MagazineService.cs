using Library.BLL.ViewModels;
using Library.DAL.EF;
using Library.DAL.Entities;
using Library.DAL.Repository;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class MagazineService
    {
        LibraryContext db;
        EFRepository<Magazine> magazineRepository;
        public MagazineService()
        {
            db = new LibraryContext();
            magazineRepository = new EFRepository<Magazine>(db);
        }

        public void Create(CreateMagazineViewModel item)
        {
            //TODO: validation
            Magazine magazine = new Magazine //TODO: automaper
            {
                Id = item.Id,
                Name = item.Name,
                YearOfPublishing = item.YearOfPublishing
            };
            magazineRepository.Create(magazine);
        }

        public IndexMagazineViewModel GetAll()
        {
            IEnumerable<Magazine> magazines = magazineRepository.GetAll();
            List<MagazineViewModel> magazineVMs = new List<MagazineViewModel>();
            foreach (Magazine item in magazines) //TODO: automaper
            {
                MagazineViewModel magazineVM = new MagazineViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    YearOfPublishing = item.YearOfPublishing
                };
                magazineVMs.Add(magazineVM);
            }

            return new IndexMagazineViewModel { magazines = magazineVMs };
        }
    }
}
