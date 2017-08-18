using Library.DAL.EF;
using Library.DAL.Repository;
using Library.Shared.Entities;
using Library.Shared.ViewModels.Brochure;
using System;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class BrochureService
    {
        LibraryContext db;
        BrochureRepository brochureRepository;

        public BrochureService()
        {
            db = new LibraryContext();
            brochureRepository = new BrochureRepository(db);
        }

        public void Create(CreateBrochureViewModel item)
        {
            //TODO: validation
            Brochure broshure = new Brochure //TODO: automaper
            {
                Id = item.Id,
                Name = item.Name,
                TypeOfCover = item.TypeOfCover,
                NumberOfPages = item.NumberOfPages
            };
            brochureRepository.Create(broshure);
        }

        public IndexBrochureViewModel GetAll()
        {
            IEnumerable<Brochure> brochures = brochureRepository.GetAll();
            IndexBrochureViewModel brochureVM = new IndexBrochureViewModel();
            brochureVM.brochures = new List<BrochureViewModel>();
            foreach (Brochure item in brochures)
            {
                brochureVM.brochures.Add(new BrochureViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    TypeOfCover = item.TypeOfCover,
                    NumberOfPages = item.NumberOfPages
                });
            }

            return brochureVM;
        }
    }
}
