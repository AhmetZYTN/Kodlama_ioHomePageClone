using Kodlama_ioHomePageClone.DataAccess.Abstract;
using Kodlama_ioHomePageClone.Models;

namespace Kodlama_ioHomePageClone.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        ICourseDal _courseDal;
        public CourseDal(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        List<Course> courses;
        public CourseDal()
        {
            Course course = new Course();
            course.CourseId = 1;
            course.Title = "Test";
            course.Description = "Test12";
            course.Price = 10;

            Course course1 = new Course();
            course1.CourseId = 2;
            course1.Title = "Test";
            course1.Description = "Test12";
            course1.Price = 10;

            Course course2 = new Course();
            course2.CourseId = 3;
            course2.Title = "Test";
            course2.Description = "Test12";
            course2.Price = 10;

            courses = new List<Course>() { course, course1, course2 };
        }
            public void Insert(Course course)
        {
            _courseDal.Insert(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> List()
        {
            return _courseDal.List();
        }
    }
}
