using FA.BookStoreWeb.Data.Infrastructure;
using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service.BaseServices;

namespace FA.BookStoreWeb.Service
{
    public class AuthorService : BaseService<Author>, IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
