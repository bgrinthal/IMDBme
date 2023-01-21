using ASPNETMVC.Data;
using ASPNETMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVC.Controllers
{
    public class CategoryController : Controller
    {
        // 
        private readonly ApplicationDbContext _db;

        // populates this property above (_db)
        // has instance of dbContext and passes to contructor
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        // Main page info to load
        public IActionResult Index()
        {
            // retreives all the categories... IEnumerable is an interface for iterating over collections
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        // obj is the passed input to be added to database
        public IActionResult Create(Category obj)
        {
            // Checks if all rules defined in model are valid
            if (ModelState.IsValid) 
            {
                // adds then saves to db
                _db.Category.Add(obj);
                _db.SaveChanges();
                // redirects to action method of Index page
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        // GET - EDIT
        // id is being passed from Index.cshtml as asp-route-Id="@obj.Id"
        public IActionResult Edit(int? id)
        {
            if(id==null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);
            if (obj==null)
            {
                return NotFound();
            }

            return View(obj);
        }
        // POST - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        // obj is the passed input to be added to database
        public IActionResult Edit(Category obj)
        {
            // Checks if all rules defined in model are valid
            if (ModelState.IsValid)
            {
                // updates then saves to db
                _db.Category.Update(obj);
                _db.SaveChanges();
                // redirects to action method of Index page
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET - Delete
        // id is being passed from Index.cshtml as asp-route-Id="@obj.Id"
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        // POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        // obj is the passed input to be added to database
        public IActionResult DeletePost(int? id)
        {
            // retrieves the object
            var obj = _db.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            // updates then saves to db
            _db.Category.Remove(obj);
            _db.SaveChanges();
            // redirects to action method of Index page
                return RedirectToAction("Index");
        }
    }
}
