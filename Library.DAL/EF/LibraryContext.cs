namespace Library.DAL.EF
{
    using System.Data.Entity;
    using Library.Shared.Entities;

    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Magazine> Magazines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
