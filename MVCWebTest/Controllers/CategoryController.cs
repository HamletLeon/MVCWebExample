using MVCWebTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebTest.Controllers
{
    public class CategoryController : Controller
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public CategoryController()
        {
            Categories.AddRange(new List<Category>()
            {
                new Category { Id = 1, Description = "Cat 1" },
                new Category { Id = 2, Description = "Cat 2" },
                new Category { Id = 3, Description = "Cat 3" },
                new Category { Id = 4, Description = "Cat 4" },
                new Category { Id = 5, Description = "Cat 5" }
            });
        }
        // GET: Category
        public ActionResult Index()
        {
            return View(Categories);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var category = Categories.Where(c => c.Id == id).FirstOrDefault();
            if (category == null) return RedirectToAction("Index");

            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            return RedirectToAction("Index");
        }
    }
}
