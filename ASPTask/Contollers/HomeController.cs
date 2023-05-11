using ASPTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTask.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
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

            return View(students);
        }
    }
}
