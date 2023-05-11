using ASPTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTask.Contollers
{
    public class StudentController : Controller
    {

        private List<Student> _students = new List<Student>
            {
                new Student
                {
                    Id= 1,
                    Firstname = "Ali",
                    Lastname = "Mammadov",
                },

                new Student
                {
                    Id= 2,
                    Firstname = "Kenan",
                    Lastname = "Xasiyev",
                },

                new Student
                {
                    Id= 3,
                    Firstname = "Shahlar",
                    Lastname = "Haciyev",
                },

                new Student
                {
                    Id= 4,
                    Firstname="Semender",
                    Lastname="Qaibov"
                }
            };

        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
