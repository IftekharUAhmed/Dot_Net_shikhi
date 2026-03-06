using IntroEF.Models;
 
using Microsoft.AspNetCore.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        StudentsContext db;
        public StudentController(StudentsContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student d)
        {
            db.Students.Add(d); //query saved not committed
            db.SaveChanges(); //query commit returns no of rows affected
            TempData["Msg"] = d.Cgpa + " Created Successfully";

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var data = (from d in db.Students where d.Id == id select d).SingleOrDefault();
            return View(data);
            //db.Departments.Find(id); //Search primary key
        }
    }
}
