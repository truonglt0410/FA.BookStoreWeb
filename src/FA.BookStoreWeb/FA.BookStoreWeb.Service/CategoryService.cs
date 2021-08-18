using FA.BookStoreWeb.Data.Infrastructure;
using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service.BaseServices;

namespace FA.BookStoreWeb.Service
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
