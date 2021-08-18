using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service.BaseServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FA.BookStoreWeb.Service
{
    public interface IBookService : IBaseService<Book>
    {
        Task<IEnumerable<Book>> GetBooksByCategoryAsync(Guid categoryId);
    }
}
