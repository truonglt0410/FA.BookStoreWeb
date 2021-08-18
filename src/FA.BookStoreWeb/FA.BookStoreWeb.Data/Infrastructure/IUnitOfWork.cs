using FA.BookStoreWeb.Data.Infrastructure.BaseRepositories;
using FA.BookStoreWeb.Models.BaseEntities;
using FA.BookStoreWeb.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStoreWeb.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        BookStoreDbContext DataContext { get; }

        IGenericRepository<Category> CategoryRepository { get; }

        IGenericRepository<Book> BookRepository { get; }

        IGenericRepository<Author> AuthorRepository { get; }

        IGenericRepository<Publisher> PublisherRepository { get; }
        IGenericRepository<Review> ReviewRepository { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;
    }
}
