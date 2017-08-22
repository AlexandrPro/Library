namespace Library.DAL.EF
{
    using System.Data.Entity;
    using Library.Entities;

    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Magazine> Magazines { get; set; }
        public virtual DbSet<Brochure> Brochures { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
