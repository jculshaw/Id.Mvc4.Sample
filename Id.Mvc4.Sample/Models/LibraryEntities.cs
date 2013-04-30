using System.Data.Entity;

namespace Id.Mvc4.Sample.Models
{
    public class LibraryEntities: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public LibraryEntities()
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }
    }
}