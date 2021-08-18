using FA.BookStoreWeb.Data.Infrastructure;
using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service.BaseServices;

namespace FA.BookStoreWeb.Service
{
    public class PublisherService : BaseService<Publisher>, IPublisherService
    {
        public PublisherService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
