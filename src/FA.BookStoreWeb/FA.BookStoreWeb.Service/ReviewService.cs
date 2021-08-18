using FA.BookStoreWeb.Data.Infrastructure;
using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service.BaseServices;

namespace FA.BookStoreWeb.Service
{
    public class ReviewService : BaseService<Review>, IReviewService
    {
        public ReviewService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
