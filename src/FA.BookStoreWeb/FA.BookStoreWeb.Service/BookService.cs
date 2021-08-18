using FA.BookStoreWeb.Data.Infrastructure;
using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service.BaseServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FA.BookStoreWeb.Service
{
    public class BookService : BaseService<Book>, IBookService
    {
        public BookService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IEnumerable<Book>> GetBooksByCategoryAsync(Guid categoryId)
        {
            return await _unitOfWork.BookRepository.GetQuery().Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
