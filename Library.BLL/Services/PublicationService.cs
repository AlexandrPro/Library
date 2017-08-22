using Library.DAL.EF;
using Library.DAL.Repository;
using Library.Entities;
using Library.ViewModel.Publication;
using System.Collections.Generic;

namespace Library.BLL.Services
{
    public class PublicationService
    {
        LibraryContext db;
        PublicationRepository publicationRepository;
        public PublicationService()
        {
            db = new LibraryContext();
            publicationRepository = new PublicationRepository(db);
        }

        public IndexPublicationViewModel GetAll()
        {
            IEnumerable<Publication> publications = publicationRepository.GetAll();
            IndexPublicationViewModel publicationVM = new IndexPublicationViewModel();
            publicationVM.publications = new List<PublicationViewModel>();
            List<PublicationViewModel> publicationVMs = new List<PublicationViewModel>();
            foreach (var publication in publications) 
            {
                publicationVM.publications.Add(new PublicationViewModel
                {
                    Id = publication.Id,
                    Name = publication.Name,
                    Type = publication.Type
                });
            }

            return publicationVM;
        }
    }
}
