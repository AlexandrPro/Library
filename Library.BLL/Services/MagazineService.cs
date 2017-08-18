using Library.DAL.EF;
using Library.DAL.Repository;
using Library.Shared.Entities;
using Library.Shared.ViewModels.Magazine;
using System;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class MagazineService
    {
        LibraryContext db;
        MagazineRepository magazineRepository;
        public MagazineService()
        {
            db = new LibraryContext();
            magazineRepository = new MagazineRepository(db);
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
            IndexMagazineViewModel magazineVM = new IndexMagazineViewModel();
            magazineVM.magazines = new List<MagazineViewModel>();
            foreach (Magazine item in magazines) 
            {
                magazineVM.magazines.Add(new MagazineViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    YearOfPublishing = item.YearOfPublishing
                });
                //magazineVMs.Add(magazineVM);
            }

            return magazineVM;
        }
    }
}
