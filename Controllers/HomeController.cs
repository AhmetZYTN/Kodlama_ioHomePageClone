using Kodlama_ioHomePageClone.Business.Abstract;
using Kodlama_ioHomePageClone.Business.Concrete;
using Kodlama_ioHomePageClone.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kodlama_ioHomePageClone.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ICourseService _courseService;

        public HomeController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Crud() {
        return View();
        }

        // GET: Course/Create
        public IActionResult KursEkle()
        {
            ViewData["CourseId"] = _courseService.GetCourseById(1); // Doðru kullaným
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult KursEkle([Bind("CourseId,Title,Description,CategoryId,Price,InstructorId")] Course courseModel)
        {
            if (ModelState.IsValid)
            {
                Course newCourse = new Course
                {
                    CourseId = _courseService.GetList().Count + 1, 
                    Title = courseModel.Title,
                    Description = courseModel.Description,
                    CategoryId = courseModel.CategoryId,
                    Price = courseModel.Price,
                    InstructorId = courseModel.InstructorId
                };

                _courseService.CourseAdd(newCourse);

                return RedirectToAction(nameof(Index));
            }

            return View(courseModel);
        }



        public IActionResult MyCourse()
        {
            var myCourses = _courseService.GetList(); 
            return View(myCourses);
        }
        public IActionResult Career()
        {
            return View();
        }
        public IActionResult AllCourse()
        {
            var courses = _courseService.GetList();
            return View(courses);
        }
        public IActionResult Questions()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
