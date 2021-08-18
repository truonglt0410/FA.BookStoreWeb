using FA.BookStoreWeb.Models.Common;
using FA.BookStoreWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FA.BookStoreWeb.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoyService;
        public HomeController(IBookService bookService, ICategoryService categoyService)
        {
            _bookService = bookService;
            _categoyService = categoyService;
        }

        [HttpGet]
        public async Task<ActionResult> Index(string searchString, string currentFilter, int? pageIndex = 1, int? pageSize = 3)
        {
            ViewData["CurrentPageSize"] = pageSize;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            // x => x.Name.Contains(searchString)
            Expression<Func<Book, bool>> filter = null;

            if (!string.IsNullOrEmpty(searchString))
            {
                filter = c => c.Title.Contains(searchString);
            }

            Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = x => x.OrderByDescending(p => p.CreatedDate);

            var books = await _bookService.GetAsync(filter: filter, orderBy: orderBy, pageIndex: pageIndex ?? 1, pageSize: pageSize ?? 3);

            return View(books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}