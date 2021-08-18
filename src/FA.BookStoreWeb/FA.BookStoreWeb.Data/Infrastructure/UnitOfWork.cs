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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreDbContext _dbContext;

        public BookStoreDbContext DataContext => _dbContext;

        public UnitOfWork(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        private IGenericRepository<Category> _categoryRepository;

        public IGenericRepository<Category> CategoryRepository =>
            _categoryRepository ?? new GenericRepository<Category>(_dbContext);

        private IGenericRepository<Book> _bookRepository;

        public IGenericRepository<Book> BookRepository =>
            _bookRepository ?? new GenericRepository<Book>(_dbContext);

        private IGenericRepository<Author> _authorRepository;

        public IGenericRepository<Author> AuthorRepository =>
            _authorRepository ?? new GenericRepository<Author>(_dbContext);

        private IGenericRepository<Publisher> _publisherRepository;

        public IGenericRepository<Publisher> PublisherRepository =>
            _publisherRepository ?? new GenericRepository<Publisher>(_dbContext);

        private IGenericRepository<Review> _reviewRepository;

        public IGenericRepository<Review> ReviewRepository =>
            _reviewRepository ?? new GenericRepository<Review>(_dbContext);

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();

        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_dbContext);
        }

        public void Dispose()
        {
            this._dbContext.Dispose();
        }
    }
}
