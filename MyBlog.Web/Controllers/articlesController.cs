using Microsoft.AspNetCore.Mvc;
using MyBlog.Web.Data;
using MyBlog.Web.Models;

namespace MyBlog.Web.Controllers
{
    public class articlesController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public articlesController( ApplicationDbContext db)
        {
                _applicationDbContext= db;
        }
        public IActionResult Index()
        {
            IEnumerable<articles> objArticlesList = _applicationDbContext.Articles;
            return View(objArticlesList);
        }
    }
}
