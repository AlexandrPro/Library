using Library.BLL.ViewModels;
using System.Collections.Generic;

namespace Library.BLL.Interfaces
{
    public interface IBookService 
    {
        void Create(BookVM bookVM);
        IEnumerable<BookVM> GetAll();
    }
}
