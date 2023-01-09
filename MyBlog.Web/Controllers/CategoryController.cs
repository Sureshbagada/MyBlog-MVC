using Microsoft.AspNetCore.Mvc;
using MyBlog.Web.Data;
using MyBlog.Web.Models;

namespace MyBlog.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryController(ApplicationDbContext db)
        {
            _applicationDbContext = db;
        }
        public IActionResult Index()
        {
            IEnumerable<categories> objCategoryList = _applicationDbContext.Categories;

            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(categories categories)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Add(categories);
                _applicationDbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            if (Id > 0)
            {
                var Cat = _applicationDbContext.Categories.Find(Id);
                if (Cat != null)
                {
                    return View(Edit(Cat));
                }
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(categories categories)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Add(categories);
                _applicationDbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult failed_jobsModel()
        {

            IEnumerable<articles> objArticlesList = _applicationDbContext.Articles;
            return View(objArticlesList);
        }
    }

}
