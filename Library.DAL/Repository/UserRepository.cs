using Library.Entities;
using System.Data.Entity;

namespace Library.DAL.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
