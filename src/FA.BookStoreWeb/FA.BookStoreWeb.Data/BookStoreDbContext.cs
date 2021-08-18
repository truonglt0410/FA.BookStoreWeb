using System;
using System.Data.Entity;
using System.Threading.Tasks;
using FA.BookStoreWeb.Data.Security;
using FA.BookStoreWeb.Models.BaseEntities;
using FA.BookStoreWeb.Models.Common;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FA.BookStoreWeb.Data
{
    public class BookStoreDbContext : IdentityDbContext<User>
    {
        public BookStoreDbContext()
            : base("BookStoreDbConn", throwIfV1Schema: false)
        {
        }

        static BookStoreDbContext()
        {
            // Set the database initializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer(new BookStoreDbInitializer());
        }

        public static BookStoreDbContext Create()
        {
            return new BookStoreDbContext();
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Review> Reviews { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasMany(p => p.Books)
                .WithMany(t => t.Authors)
                .Map(pt =>
                {
                    pt.MapLeftKey("AuthorId");
                    pt.MapRightKey("BookId");
                    pt.ToTable("AuthorBook");
                });
        }

        public override int SaveChanges()
        {
            BeforeSaveChanges();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            BeforeSaveChanges();
            return await base.SaveChangesAsync();
        }

        private void BeforeSaveChanges()
        {
            var entities = this.ChangeTracker.Entries();
            foreach (var entry in entities)
            {
                if (entry.Entity is IBaseEntity entityBase)
                {
                    var now = DateTime.Now;
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            entityBase.UpdatedAt = now;
                            break;

                        case EntityState.Added:
                            entityBase.InsertedAt = now;
                            entityBase.UpdatedAt = now;
                            break;
                    }
                }

            }
        }
    }
}